using Svg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconLibrary.IconConverter.Files
{
    public class SvgIconFile : IconFile
    {
        private SvgDocument m_svgDoc;

        public SvgIconFile(string filePath)
            : base(Path.GetFileNameWithoutExtension(filePath))
        {
            m_svgDoc = SvgDocument.Open(filePath);
            m_svgDoc.Overflow = SvgOverflow.Auto;

            this.FlatternTolerance = 10f;
        }

        public override void Draw(Graphics target, int width, int height)
        {
            using (var renderer = new SvgSimplifiedRenderer(target, Color.Black, this.FlatternTolerance))
            {
                renderer.SetBoundable(new GenericBoundable(0f, 0f, width, height));

                var dimensions = m_svgDoc.GetDimensions();
                renderer.ScaleTransform((float)width / dimensions.Width, (float)height / dimensions.Height, MatrixOrder.Append);

                m_svgDoc.Draw(renderer);
            }
        }

        public float FlatternTolerance
        {
            get;
            set;
        }

        //*********************************************************************
        //*********************************************************************
        //*********************************************************************
        internal class GenericBoundable : ISvgBoundable
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
