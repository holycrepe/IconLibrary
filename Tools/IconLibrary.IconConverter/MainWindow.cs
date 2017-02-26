using IconLibrary.IconConverter.Files;
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
            m_dataSourceFiles.DataSource = m_fileContainer;
        }

        private void OnCmdImport_Click(object sender, EventArgs e)
        {
            if(m_dlgImportFile.ShowDialog(this) == DialogResult.OK)
            {
                m_fileContainer.IconFiles.Add(
                    new SvgIconFile(m_dlgImportFile.FileName));
            }
        }

        private void OnLstIcons_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_propSelectedFile.SelectedObject =
                m_lstIcons.SelectedItem;
        }
    }
}
