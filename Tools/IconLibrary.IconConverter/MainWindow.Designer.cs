using IconLibrary.IconConverter.Util;

namespace IconLibrary.IconConverter
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.m_barTools = new System.Windows.Forms.ToolStrip();
            this.m_toolImportFile = new System.Windows.Forms.ToolStripButton();
            this.m_toolImportFontSymbol = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_toolRemoveIcon = new System.Windows.Forms.ToolStripButton();
            this.m_splitter = new System.Windows.Forms.SplitContainer();
            this.m_splitterDetail = new System.Windows.Forms.SplitContainer();
            this.m_grpLoadedFiles = new System.Windows.Forms.GroupBox();
            this.m_lstIcons = new System.Windows.Forms.ListBox();
            this.m_dataSourceFiles = new System.Windows.Forms.BindingSource(this.components);
            this.m_grpProperties = new System.Windows.Forms.GroupBox();
            this.m_propSelectedFile = new System.Windows.Forms.PropertyGrid();
            this.m_panRenderPanel = new IconLibrary.IconConverter.Util.RenderPanel();
            this.m_iconsEditor = new IconLibrary.EditorIconImageList(this.components);
            this.m_dlgImportFile = new System.Windows.Forms.OpenFileDialog();
            this.m_refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.m_barTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_splitter)).BeginInit();
            this.m_splitter.Panel1.SuspendLayout();
            this.m_splitter.Panel2.SuspendLayout();
            this.m_splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_splitterDetail)).BeginInit();
            this.m_splitterDetail.Panel1.SuspendLayout();
            this.m_splitterDetail.Panel2.SuspendLayout();
            this.m_splitterDetail.SuspendLayout();
            this.m_grpLoadedFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dataSourceFiles)).BeginInit();
            this.m_grpProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_barTools
            // 
            this.m_barTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.m_barTools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_barTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_toolImportFile,
            this.m_toolImportFontSymbol,
            this.toolStripSeparator1,
            this.m_toolRemoveIcon});
            this.m_barTools.Location = new System.Drawing.Point(0, 0);
            this.m_barTools.Name = "m_barTools";
            this.m_barTools.Size = new System.Drawing.Size(769, 27);
            this.m_barTools.TabIndex = 1;
            this.m_barTools.Text = "toolStrip1";
            // 
            // m_toolImportFile
            // 
            this.m_toolImportFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_toolImportFile.Image = ((System.Drawing.Image)(resources.GetObject("m_toolImportFile.Image")));
            this.m_toolImportFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_toolImportFile.Name = "m_toolImportFile";
            this.m_toolImportFile.Size = new System.Drawing.Size(24, 24);
            this.m_toolImportFile.Text = "Import file";
            this.m_toolImportFile.Click += new System.EventHandler(this.OnCmdImport_Click);
            // 
            // m_toolImportFontSymbol
            // 
            this.m_toolImportFontSymbol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_toolImportFontSymbol.Image = ((System.Drawing.Image)(resources.GetObject("m_toolImportFontSymbol.Image")));
            this.m_toolImportFontSymbol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_toolImportFontSymbol.Name = "m_toolImportFontSymbol";
            this.m_toolImportFontSymbol.Size = new System.Drawing.Size(24, 24);
            this.m_toolImportFontSymbol.Text = "Import font symbol";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // m_toolRemoveIcon
            // 
            this.m_toolRemoveIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_toolRemoveIcon.Image = ((System.Drawing.Image)(resources.GetObject("m_toolRemoveIcon.Image")));
            this.m_toolRemoveIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_toolRemoveIcon.Name = "m_toolRemoveIcon";
            this.m_toolRemoveIcon.Size = new System.Drawing.Size(24, 24);
            this.m_toolRemoveIcon.Text = "Remove icon";
            // 
            // m_splitter
            // 
            this.m_splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.m_splitter.Location = new System.Drawing.Point(0, 27);
            this.m_splitter.Name = "m_splitter";
            // 
            // m_splitter.Panel1
            // 
            this.m_splitter.Panel1.Controls.Add(this.m_splitterDetail);
            // 
            // m_splitter.Panel2
            // 
            this.m_splitter.Panel2.BackColor = System.Drawing.Color.White;
            this.m_splitter.Panel2.Controls.Add(this.m_panRenderPanel);
            this.m_splitter.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.m_splitter.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnSplitterPanel_Paint);
            this.m_splitter.Size = new System.Drawing.Size(769, 441);
            this.m_splitter.SplitterDistance = 256;
            this.m_splitter.TabIndex = 2;
            // 
            // m_splitterDetail
            // 
            this.m_splitterDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_splitterDetail.Location = new System.Drawing.Point(0, 0);
            this.m_splitterDetail.Name = "m_splitterDetail";
            this.m_splitterDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // m_splitterDetail.Panel1
            // 
            this.m_splitterDetail.Panel1.Controls.Add(this.m_grpLoadedFiles);
            // 
            // m_splitterDetail.Panel2
            // 
            this.m_splitterDetail.Panel2.Controls.Add(this.m_grpProperties);
            this.m_splitterDetail.Size = new System.Drawing.Size(256, 441);
            this.m_splitterDetail.SplitterDistance = 221;
            this.m_splitterDetail.TabIndex = 0;
            // 
            // m_grpLoadedFiles
            // 
            this.m_grpLoadedFiles.Controls.Add(this.m_lstIcons);
            this.m_grpLoadedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grpLoadedFiles.Location = new System.Drawing.Point(0, 0);
            this.m_grpLoadedFiles.Name = "m_grpLoadedFiles";
            this.m_grpLoadedFiles.Size = new System.Drawing.Size(256, 221);
            this.m_grpLoadedFiles.TabIndex = 0;
            this.m_grpLoadedFiles.TabStop = false;
            this.m_grpLoadedFiles.Text = "Loaded files";
            // 
            // m_lstIcons
            // 
            this.m_lstIcons.DataSource = this.m_dataSourceFiles;
            this.m_lstIcons.DisplayMember = "Name";
            this.m_lstIcons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_lstIcons.FormattingEnabled = true;
            this.m_lstIcons.ItemHeight = 16;
            this.m_lstIcons.Location = new System.Drawing.Point(3, 18);
            this.m_lstIcons.Name = "m_lstIcons";
            this.m_lstIcons.Size = new System.Drawing.Size(250, 200);
            this.m_lstIcons.TabIndex = 0;
            this.m_lstIcons.SelectedIndexChanged += new System.EventHandler(this.OnLstIcons_SelectedIndexChanged);
            // 
            // m_dataSourceFiles
            // 
            this.m_dataSourceFiles.DataMember = "IconFiles";
            this.m_dataSourceFiles.DataSource = typeof(IconLibrary.IconConverter.Files.IconFileContainer);
            // 
            // m_grpProperties
            // 
            this.m_grpProperties.Controls.Add(this.m_propSelectedFile);
            this.m_grpProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grpProperties.Location = new System.Drawing.Point(0, 0);
            this.m_grpProperties.Name = "m_grpProperties";
            this.m_grpProperties.Size = new System.Drawing.Size(256, 216);
            this.m_grpProperties.TabIndex = 0;
            this.m_grpProperties.TabStop = false;
            this.m_grpProperties.Text = "Properties";
            // 
            // m_propSelectedFile
            // 
            this.m_propSelectedFile.CommandsVisibleIfAvailable = false;
            this.m_propSelectedFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_propSelectedFile.HelpVisible = false;
            this.m_propSelectedFile.Location = new System.Drawing.Point(3, 18);
            this.m_propSelectedFile.Name = "m_propSelectedFile";
            this.m_propSelectedFile.Size = new System.Drawing.Size(250, 195);
            this.m_propSelectedFile.TabIndex = 0;
            this.m_propSelectedFile.ToolbarVisible = false;
            // 
            // m_panRenderPanel
            // 
            this.m_panRenderPanel.BackColor = System.Drawing.Color.White;
            this.m_panRenderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_panRenderPanel.Location = new System.Drawing.Point(5, 5);
            this.m_panRenderPanel.Name = "m_panRenderPanel";
            this.m_panRenderPanel.Size = new System.Drawing.Size(499, 431);
            this.m_panRenderPanel.TabIndex = 0;
            this.m_panRenderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPanRenderPanel_Paint);
            // 
            // m_iconsEditor
            // 
            this.m_iconsEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.m_iconsEditor.HostControl = this;
            this.m_iconsEditor.Object001 = this.m_toolImportFontSymbol;
            this.m_iconsEditor.Object002 = this.m_toolImportFile;
            this.m_iconsEditor.Object002Icon = "Import";
            this.m_iconsEditor.Object003 = this.m_toolRemoveIcon;
            this.m_iconsEditor.Object003Icon = "Close";
            // 
            // m_dlgImportFile
            // 
            this.m_dlgImportFile.Filter = "SVG-Files (*.svg)|*.svg";
            this.m_dlgImportFile.Multiselect = true;
            // 
            // m_refreshTimer
            // 
            this.m_refreshTimer.Enabled = true;
            this.m_refreshTimer.Interval = 500;
            this.m_refreshTimer.Tick += new System.EventHandler(this.OnRefreshTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 468);
            this.Controls.Add(this.m_splitter);
            this.Controls.Add(this.m_barTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "IconConverter";
            this.m_barTools.ResumeLayout(false);
            this.m_barTools.PerformLayout();
            this.m_splitter.Panel1.ResumeLayout(false);
            this.m_splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_splitter)).EndInit();
            this.m_splitter.ResumeLayout(false);
            this.m_splitterDetail.Panel1.ResumeLayout(false);
            this.m_splitterDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_splitterDetail)).EndInit();
            this.m_splitterDetail.ResumeLayout(false);
            this.m_grpLoadedFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_dataSourceFiles)).EndInit();
            this.m_grpProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip m_barTools;
        private System.Windows.Forms.SplitContainer m_splitter;
        private System.Windows.Forms.ListBox m_lstIcons;
        private EditorIconImageList m_iconsEditor;
        private System.Windows.Forms.ToolStripButton m_toolImportFile;
        private System.Windows.Forms.OpenFileDialog m_dlgImportFile;
        private System.Windows.Forms.BindingSource m_dataSourceFiles;
        private System.Windows.Forms.SplitContainer m_splitterDetail;
        private System.Windows.Forms.GroupBox m_grpLoadedFiles;
        private System.Windows.Forms.GroupBox m_grpProperties;
        private System.Windows.Forms.PropertyGrid m_propSelectedFile;
        private RenderPanel m_panRenderPanel;
        private System.Windows.Forms.Timer m_refreshTimer;
        private System.Windows.Forms.ToolStripButton m_toolImportFontSymbol;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton m_toolRemoveIcon;
    }
}

