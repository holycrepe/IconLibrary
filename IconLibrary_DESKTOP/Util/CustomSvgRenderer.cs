using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svg;

namespace IconLibrary.Util
{
    public class CustomSvgRenderer : Svg.ISvgRenderer
    {
        private Svg.ISvgRenderer m_defaultRenderer;
        private Color m_customColor;
        private Brush m_customBrush;
        private Pen m_customPen;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSvgRenderer"/> class.
        /// </summary>
        public CustomSvgRenderer(Bitmap targetBitmap, Color customColor)
        {
            m_defaultRenderer = Svg.SvgRenderer.FromImage(targetBitmap);
            m_customColor = customColor;
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
            if(m_customPen == null) { m_customPen = new Pen(m_customColor); }

            m_defaultRenderer.DrawPath(m_customPen, path);
        }

        public void FillPath(Brush brush, GraphicsPath path)
        {
            if(m_customBrush == null) { m_customBrush = new SolidBrush(m_customColor); }

            m_defaultRenderer.FillPath(m_customBrush, path);
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
            m_defaultRenderer.ScaleTransform(sx, sy, order);
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
