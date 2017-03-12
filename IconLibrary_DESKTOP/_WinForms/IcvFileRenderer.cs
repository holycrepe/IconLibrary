using IconLibrary.IcvFormat;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconLibrary
{
    public static class IcvFileRenderer
    {
        /// <summary>
        /// Renders the given icon
        /// </summary>
        /// <param name="icon"></param>
        /// <param name="graphics"></param>
        /// <param name="origin"></param>
        /// <param name="size"></param>
        public static void Render(IcvIcon icon, Graphics graphics, PointF origin, SizeF size)
        {
            float resizeX = size.Width / (float)IcvIcon.REFERENCE_SIDE_WIDTH;
            float resizeY = size.Height / (float)IcvIcon.REFERENCE_SIDE_WIDTH;
            foreach(var actFigure in icon.Figures)
            {
                using (var actFillBrush = new SolidBrush(Color.FromArgb(actFigure.FillColorCode)))
                using (var actDrawingPath = new GraphicsPath())
                {
                    // Build the graphics path dynamically
                    foreach (var actPath in actFigure.Paths)
                    {
                        actDrawingPath.StartFigure();

                        actDrawingPath.AddLines(actPath.PointList
                            .Select((actIcvPoint) => new PointF(
                                origin.X + (float)actIcvPoint.X * resizeX, 
                                origin.Y + (float)actIcvPoint.Y * resizeY))
                            .ToArray());

                        actDrawingPath.CloseFigure();
                    }

                    // Render the path on the screen
                    graphics.FillPath(actFillBrush, actDrawingPath);
                }
            }
        }
    }
}
