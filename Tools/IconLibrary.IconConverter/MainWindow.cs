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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            m_fileContainer = new IconFileContainer();
            m_fileContainer.IconCollectionChanged += OnFileContainer_IconCollectionChanged;
            m_fileContainer.PropertyChanged += OnFileContainer_PropertyChanged;

            m_dataSourceFiles.DataSource = m_fileContainer;
        }

        private void OnFileContainer_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case nameof(IconFileContainer.PreviewIcon):
                    m_panRenderPanel.Icon = m_fileContainer.PreviewIcon;
                    m_panRenderPanel.Invalidate();
                    break;
            }
        }

        private void OnFileContainer_IconCollectionChanged(object sender, EventArgs e)
        {
            m_dataSourceFiles.ResetBindings(false);
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

        private void OnCmdDelete_Click(object sender, EventArgs e)
        {
            var selectedIcon = m_lstIcons.SelectedItem as IconFile;
            if(selectedIcon == null) { return; }

            m_fileContainer.IconFiles.Remove(selectedIcon);
        }

        private void OnLstIcons_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_propSelectedFile.SelectedObject = m_lstIcons.SelectedItem;
            m_fileContainer.SelectedIcon = m_lstIcons.SelectedItem as IconFile;
        }

        private void OnSplitterPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(
                Pens.Gray,
                e.ClipRectangle.X, e.ClipRectangle.Y,
                e.ClipRectangle.Width -1, e.ClipRectangle.Height - 1);
        }
    }
}
