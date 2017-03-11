using IconLibrary.IcvFormat;
using Svg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconLibrary.IconConverter.Files
{
    public class SvgToIcvRenderer : ISvgRenderer
    {
        #region Configuration
        private float m_flatternTolerance;
        #endregion

        #region Parameters during conversion
        private float m_translationX;
        private float m_translationY;
        private float m_scalingX;
        private float m_scalingY;
        #endregion

        #region Result
        private IcvIcon m_generatedIcon;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSvgRenderer"/> class.
        /// </summary>
        public SvgToIcvRenderer(float flatternTolerance)
        {
            m_flatternTolerance = flatternTolerance;

            m_generatedIcon = new IcvIcon();
        }

        public void Dispose()
        {

        }

        public void DrawImage(Image image, RectangleF destRect, RectangleF srcRect, GraphicsUnit graphicsUnit)
        {
            // Not supported
        }

        public void DrawImageUnscaled(Image image, Point location)
        {
            // Not supported
        }

        public void DrawPath(Pen pen, GraphicsPath path)
        {
            // Not supported
        }

        public void FillPath(Brush brush, GraphicsPath path)
        {
            IcvFigure newFigure = new IcvFigure();

            // Get the fill color
            var solidBrush = brush as SolidBrush;
            if(solidBrush != null)
            {
                newFigure.FillColorCode = solidBrush.Color.ToArgb();
            }

            // Work with copied path
            using (GraphicsPath customPath = new GraphicsPath(path.PathPoints, path.PathTypes))
            {
                // Flattern (converts the path to a line-list)
                customPath.Flatten(null, m_flatternTolerance);

                List<IcvPoint> actIcvPathRaw = new List<IcvPoint>(customPath.PathPoints.Length);
                for (int loop = 0; loop < customPath.PathPoints.Length; loop++)
                {
                    // Convert Gdi-Point to Icv-Point
                    var actPoint = customPath.PathPoints[loop];
                    var icvPoint = new IcvPoint(
                        (ushort)(m_translationX + actPoint.X * m_scalingX),
                        (ushort)(m_translationY + actPoint.Y * m_scalingY));

                    var actType = customPath.PathTypes[loop];
                    if (actType < 100)
                    {
                        actIcvPathRaw.Add(icvPoint);
                    }
                    else
                    {
                        actIcvPathRaw.Add(icvPoint);

                        newFigure.Paths.Add(new IcvPath(actIcvPathRaw.ToArray()));
                        actIcvPathRaw.Clear();
                    }
                }
            }

            // Append the new figure to the icon
            if (newFigure.Paths.Count > 0)
            {
                m_generatedIcon.Figures.Add(newFigure);
            }
        }

        public ISvgBoundable GetBoundable()
        {
            return null;
        }

        public Region GetClip()
        {
            return new Region(new RectangleF(0, 0, IcvIcon.REFERENCE_SIDE_WIDTH, IcvIcon.REFERENCE_SIDE_WIDTH));
        }

        public ISvgBoundable PopBoundable()
        {
            return null;
        }

        public void RotateTransform(float fAngle, MatrixOrder order = MatrixOrder.Append)
        {
            //m_defaultRenderer.RotateTransform(fAngle, order);
        }

        public void ScaleTransform(float sx, float sy, MatrixOrder order = MatrixOrder.Append)
        {
            m_scalingX = sx;
            m_scalingY = sy;

            //m_graphics.ScaleTransform(sx, sy);
            //m_defaultRenderer.ScaleTransform(sx, sy, order);
        }

        public void SetBoundable(ISvgBoundable boundable)
        {
            //m_defaultRenderer.SetBoundable(boundable);
        }

        public void SetClip(Region region, CombineMode combineMode = CombineMode.Replace)
        {
            //m_defaultRenderer.SetClip(region, combineMode);
        }

        public void TranslateTransform(float dx, float dy, MatrixOrder order = MatrixOrder.Append)
        {
            m_translationX = dx;
            m_translationY = dy;
            //m_defaultRenderer.TranslateTransform(dx, dy, order);
        }

        public float DpiY
        {
            get { return 96f; }
        }

        public SmoothingMode SmoothingMode
        {
            get { return SmoothingMode.HighQuality; }
            set { }
        }

        public Matrix Transform
        {
            get { return null; }
            set {  }
        }

        public IcvIcon GeneratedIcon
        {
            get { return m_generatedIcon; }
        }
    }
}
