using IconLibrary.IconConverter.Files;
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

namespace IconLibrary.IconConverter
{
    public partial class MainWindow : Form
    {
        private IconFileContainer m_fileContainer;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnPanRenderPanel_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            using (Brush fillBrush = new SolidBrush(Color.White))
            {
                graphics.FillRectangle(fillBrush, e.ClipRectangle);
            }

            int sideWidth = e.ClipRectangle.Width;
            if(e.ClipRectangle.Height < sideWidth) { sideWidth = e.ClipRectangle.Height; }

            var selectedFile = m_lstIcons.SelectedItem as IconFile;
            if(selectedFile != null)
            {
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                selectedFile.Draw(graphics, sideWidth, sideWidth);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            m_fileContainer = new IconFileContainer();
            m_dataSourceFiles.DataSource = m_fileContainer;
        }

        private void OnCmdImport_Click(object sender, EventArgs e)
        {
            if(m_dlgImportFile.ShowDialog(this) == DialogResult.OK)
            {
                SvgIconFile iconFile = null;
                foreach(string actFile in m_dlgImportFile.FileNames)
                {
                    iconFile = new SvgIconFile(actFile);
                    m_fileContainer.IconFiles.Add(iconFile);
                }

                if (iconFile != null) { m_lstIcons.SelectedItem = iconFile; }
            }
        }

        private void OnLstIcons_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_propSelectedFile.SelectedObject =
                m_lstIcons.SelectedItem;

            m_panRenderPanel.Invalidate();
        }

        private void OnRefreshTimer_Tick(object sender, EventArgs e)
        {
            m_panRenderPanel.Invalidate();
        }

        private void OnSplitterPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(
                Pens.Gray,
                e.ClipRectangle.X, e.ClipRectangle.Y,
                e.ClipRectangle.Width -1, e.ClipRectangle.Height - 1);
        }

        private void OnCmdTest_Click(object sender, EventArgs e)
        {
            SvgIconFile selectedFile = m_lstIcons.SelectedItem
                as SvgIconFile;
            if(selectedFile != null)
            {
                IcvIcon icvIcon = selectedFile.ConvertToIcv();
            }
        }
    }
}
