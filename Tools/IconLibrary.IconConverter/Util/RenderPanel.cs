using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IconLibrary.IconConverter.Util
{
    public class RenderPanel : UserControl
    {
        public RenderPanel()
        {
            //Set style parameters for this control
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.Opaque, true);
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            base.DoubleBuffered = true;
        }
    }
}
