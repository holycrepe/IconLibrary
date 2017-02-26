using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IconLibrary.Caching
{
    /// <summary>
    /// This class is responsible for caching all icons which where loaded before.
    /// </summary>
    public partial class IconImageCache
    {
        #region Caches
        private Dictionary<string, System.Windows.Media.Imaging.BitmapImage> m_wpfBitmapImages
            = new Dictionary<string, System.Windows.Media.Imaging.BitmapImage>(1024);
        private Dictionary<string, System.Drawing.Image> m_gdiImages
            = new Dictionary<string, System.Drawing.Image>();
        #endregion

        public void ClearCache()
        {
            m_wpfBitmapImages = new Dictionary<string, System.Windows.Media.Imaging.BitmapImage>(1024);
            m_gdiImages = new Dictionary<string, System.Drawing.Image>(1024);
        }

        /// <summary>
        /// Gets the WPF bitmap image.
        /// </summary>
        internal System.Windows.Media.Imaging.BitmapImage GetWpfBitmapImage(IconCollectionInfo collectionInfo, IconFileInfo fileInfo)
        {
            string iconFileKey = GetIconFileKey(collectionInfo, fileInfo);

            // Load the ImageSource (me may have cached it before
            System.Windows.Media.Imaging.BitmapImage result = null;
            if (!m_wpfBitmapImages.TryGetValue(iconFileKey, out result))
            {
                // Try to load the icon from png file
                var pngIconLink = TryFindPngIcon(collectionInfo, fileInfo);
                if(pngIconLink != null)
                {
                    using (Stream inStream = pngIconLink.OpenRead())
                    {
                        result = new System.Windows.Media.Imaging.BitmapImage();
                        result.BeginInit();
                        result.StreamSource = inStream;
                        result.EndInit();
                        result.Freeze();
                    }
                }

                m_wpfBitmapImages.Add(iconFileKey, result);
            }

            return result;
        }

        internal System.Drawing.Image GetGdiImage(IconCollectionInfo collectionInfo, IconFileInfo fileInfo)
        {
            string iconFileKey = GetIconFileKey(collectionInfo, fileInfo);

            System.Drawing.Image result = null;
            if (!m_gdiImages.TryGetValue(iconFileKey, out result))
            {
                // Try to load the icon from svg file
                var svgIconLink = TryFindSvgIcon(collectionInfo, fileInfo);
                if (svgIconLink != null)
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    using (Stream inStream = svgIconLink.OpenRead())
                    {
                        Svg.SvgDocument svgDoc = Svg.SvgDocument.Open<Svg.SvgDocument>(inStream);
                        System.Drawing.Bitmap targetBitmap = new System.Drawing.Bitmap(fileInfo.ImageSideWidth, fileInfo.ImageSideWidth);
                        using (Svg.ISvgRenderer svgRenderer = Svg.SvgRenderer.FromImage(targetBitmap))
                        {
                            svgDoc.Overflow = Svg.SvgOverflow.Auto;

                            svgRenderer.SetBoundable(new GenericBoundable(0f, 0f, (float)targetBitmap.Width, (float)targetBitmap.Height));

                            SizeF dimensions = svgDoc.GetDimensions();
                            svgRenderer.ScaleTransform((float)targetBitmap.Width / dimensions.Width, (float)targetBitmap.Height / dimensions.Height, MatrixOrder.Append);

                            svgDoc.Draw(svgRenderer);
                        }
                        result = targetBitmap;
                    }

                    sw.Stop();
                }

                // Try to load the icon from png file
                if (result == null)
                {
                    var pngIconLink = TryFindPngIcon(collectionInfo, fileInfo);
                    if (pngIconLink != null)
                    {
                        using (Stream inStream = pngIconLink.OpenRead())
                        {
                            result = System.Drawing.Bitmap.FromStream(inStream);
                        }
                    }
                }

                m_gdiImages[iconFileKey] = result;
            }

            return result;
        }

        public int CachedImageCountWpf => m_wpfBitmapImages.Count;

        public int CachedImageCountWinForms => m_gdiImages.Count;

        //*********************************************************************
        //*********************************************************************
        //*********************************************************************
        internal class GenericBoundable : Svg.ISvgBoundable
        {
            private RectangleF m_rectangle;

            public GenericBoundable(RectangleF rect)
            {
                this.m_rectangle = rect;
            }

            public GenericBoundable(float x, float y, float width, float height)
            {
                this.m_rectangle = new RectangleF(x, y, width, height);
            }

            public PointF Location
            {
                get
                {
                    return this.m_rectangle.Location;
                }
            }

            public SizeF Size
            {
                get
                {
                    return this.m_rectangle.Size;
                }
            }

            public RectangleF Bounds
            {
                get
                {
                    return this.m_rectangle;
                }
            }
        }
    }
}
