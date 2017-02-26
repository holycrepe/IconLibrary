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
    public class SvgSimplifiedRenderer : ISvgRenderer
    {
        private Graphics m_graphics;
        private ISvgRenderer m_defaultRenderer;
        private Color m_customColor;
        private Brush m_customBrush;
        private Pen m_customPen;
        private float m_flatternTolerance;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSvgRenderer"/> class.
        /// </summary>
        public SvgSimplifiedRenderer(Graphics graphics, Color customColor, float flatternTolerance)
        {
            m_graphics = graphics;
            m_defaultRenderer = SvgRenderer.FromNull();
            m_customColor = customColor;
            m_flatternTolerance = flatternTolerance;
        }

        public void Dispose()
        {
            m_defaultRenderer.Dispose();
            if (m_customBrush != null) { m_customBrush.Dispose(); }
            if (m_customPen != null) { m_customPen.Dispose(); }
        }

        public void DrawImage(Image image, RectangleF destRect, RectangleF srcRect, GraphicsUnit graphicsUnit)
        {
            m_defaultRenderer.DrawImage(image, destRect, srcRect, graphicsUnit);
        }

        public void DrawImageUnscaled(Image image, Point location)
        {
            m_defaultRenderer.DrawImageUnscaled(image, location);
        }

        public void DrawPath(Pen pen, GraphicsPath path)
        {
            if (m_customPen == null) { m_customPen = new Pen(m_customColor); }

            path.Flatten(null, m_flatternTolerance);

            m_defaultRenderer.DrawPath(m_customPen, path);
        }

        public void FillPath(Brush brush, GraphicsPath path)
        {
            if (m_customBrush == null) { m_customBrush = new SolidBrush(m_customColor); }

            using (GraphicsPath customPath = new GraphicsPath(path.PathPoints, path.PathTypes))
            {
                customPath.Flatten(null, m_flatternTolerance);

                using (GraphicsPath newPath = new GraphicsPath())
                {
                    List<PointF> actFigure = new List<PointF>(128);
                    for (int loop = 0; loop < customPath.PathPoints.Length; loop++)
                    {
                        var actType = customPath.PathTypes[loop];
                        if (actType < 100)
                        {
                            actFigure.Add(customPath.PathPoints[loop]);
                        }
                        else 
                        {
                            actFigure.Add(customPath.PathPoints[loop]);

                            newPath.AddPolygon(actFigure.ToArray());
                            actFigure.Clear();
                        }
                    }

                    m_graphics.FillPath(m_customBrush, newPath);
                }
            }
        }

        public ISvgBoundable GetBoundable()
        {
            return m_defaultRenderer.GetBoundable();
        }

        public Region GetClip()
        {
            return m_defaultRenderer.GetClip();
        }

        public ISvgBoundable PopBoundable()
        {
            return m_defaultRenderer.PopBoundable();
        }

        public void RotateTransform(float fAngle, MatrixOrder order = MatrixOrder.Append)
        {
            m_defaultRenderer.RotateTransform(fAngle, order);
        }

        public void ScaleTransform(float sx, float sy, MatrixOrder order = MatrixOrder.Append)
        {
            m_graphics.ScaleTransform(sx, sy);
            //m_defaultRenderer.ScaleTransform(sx, sy, order);
        }

        public void SetBoundable(ISvgBoundable boundable)
        {
            m_defaultRenderer.SetBoundable(boundable);
        }

        public void SetClip(Region region, CombineMode combineMode = CombineMode.Replace)
        {
            m_defaultRenderer.SetClip(region, combineMode);
        }

        public void TranslateTransform(float dx, float dy, MatrixOrder order = MatrixOrder.Append)
        {
            m_defaultRenderer.TranslateTransform(dx, dy, order);
        }

        public float DpiY
        {
            get { return m_defaultRenderer.DpiY; }
        }

        public SmoothingMode SmoothingMode
        {
            get { return m_defaultRenderer.SmoothingMode; }
            set { m_defaultRenderer.SmoothingMode = value; }
        }

        public Matrix Transform
        {
            get { return m_defaultRenderer.Transform; }
            set { m_defaultRenderer.Transform = value; }
        }
    }
}
