using IconLibrary.IcvFormat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IconLibrary.IconConverter.View
{
    public partial class IcvFileRendererControl : Control
    {
        private static readonly int[] RENDER_SIZES = new int[] { 16, 32, 48, 64, 128 };
        private const int ICON_PADDING = 4;

        private IcvIcon m_icvIcon;

        public IcvFileRendererControl()
        {
            InitializeComponent();

            //Set style parameters for this control
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.Opaque, true);
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            base.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            var graphics = pe.Graphics;
            var renderRect = pe.ClipRectangle;

            // Render background
            using (var bgBrush = new SolidBrush(this.BackColor))
            {
                graphics.FillRectangle(bgBrush, renderRect);
            }

            // Configure graphics
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphics.ScaleTransform(
                graphics.DpiX / 96f,
                graphics.DpiY / 96f);

            // Cancel here if we have no icon
            if(m_icvIcon == null) { return; }

            // Render the icon
            int actXPos = ICON_PADDING;
            int actYPos = ICON_PADDING;
            for(int loopSize = 0; loopSize < RENDER_SIZES.Length; loopSize++)
            {
                IcvFileRenderer.Render(
                    m_icvIcon, graphics,
                    new PointF(actXPos, actYPos),
                    new SizeF(RENDER_SIZES[loopSize], RENDER_SIZES[loopSize]));

                actXPos += (ICON_PADDING + RENDER_SIZES[loopSize]);
            }
        }

        public IcvIcon Icon
        {
            get { return m_icvIcon; }
            set
            {
                if(m_icvIcon != value)
                {
                    m_icvIcon = value;
                    this.Invalidate();
                }
            }
        }
    }
}
