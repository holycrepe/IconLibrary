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
            this.m_barMainMenu = new System.Windows.Forms.MenuStrip();
            this.m_mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuImportSymbol = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_mnuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.m_barTools = new System.Windows.Forms.ToolStrip();
            this.m_toolImport = new System.Windows.Forms.ToolStripButton();
            this.m_splitter = new System.Windows.Forms.SplitContainer();
            this.m_splitterDetail = new System.Windows.Forms.SplitContainer();
            this.m_grpLoadedFiles = new System.Windows.Forms.GroupBox();
            this.m_lstIcons = new System.Windows.Forms.ListBox();
            this.m_dataSourceFiles = new System.Windows.Forms.BindingSource(this.components);
            this.m_grpProperties = new System.Windows.Forms.GroupBox();
            this.m_propSelectedFile = new System.Windows.Forms.PropertyGrid();
            this.m_iconsEditor = new IconLibrary.EditorIconImageList(this.components);
            this.m_dlgImportFile = new System.Windows.Forms.OpenFileDialog();
            this.m_panRenderPanel = new System.Windows.Forms.Panel();
            this.m_barMainMenu.SuspendLayout();
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
            // m_barMainMenu
            // 
            this.m_barMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_barMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_mnuFile});
            this.m_barMainMenu.Location = new System.Drawing.Point(0, 0);
            this.m_barMainMenu.Name = "m_barMainMenu";
            this.m_barMainMenu.Size = new System.Drawing.Size(769, 28);
            this.m_barMainMenu.TabIndex = 0;
            // 
            // m_mnuFile
            // 
            this.m_mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_mnuImport,
            this.m_mnuImportSymbol,
            this.toolStripSeparator1,
            this.m_mnuCloseAll});
            this.m_mnuFile.Name = "m_mnuFile";
            this.m_mnuFile.Size = new System.Drawing.Size(44, 24);
            this.m_mnuFile.Text = "File";
            // 
            // m_mnuImport
            // 
            this.m_mnuImport.Image = ((System.Drawing.Image)(resources.GetObject("m_mnuImport.Image")));
            this.m_mnuImport.Name = "m_mnuImport";
            this.m_mnuImport.Size = new System.Drawing.Size(181, 26);
            this.m_mnuImport.Text = "Import file";
            this.m_mnuImport.Click += new System.EventHandler(this.OnCmdImport_Click);
            // 
            // m_mnuImportSymbol
            // 
            this.m_mnuImportSymbol.Image = ((System.Drawing.Image)(resources.GetObject("m_mnuImportSymbol.Image")));
            this.m_mnuImportSymbol.Name = "m_mnuImportSymbol";
            this.m_mnuImportSymbol.Size = new System.Drawing.Size(181, 26);
            this.m_mnuImportSymbol.Text = "Import symbol";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // m_mnuCloseAll
            // 
            this.m_mnuCloseAll.Image = ((System.Drawing.Image)(resources.GetObject("m_mnuCloseAll.Image")));
            this.m_mnuCloseAll.Name = "m_mnuCloseAll";
            this.m_mnuCloseAll.Size = new System.Drawing.Size(181, 26);
            this.m_mnuCloseAll.Text = "Close all";
            // 
            // m_barTools
            // 
            this.m_barTools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_barTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_toolImport});
            this.m_barTools.Location = new System.Drawing.Point(0, 28);
            this.m_barTools.Name = "m_barTools";
            this.m_barTools.Size = new System.Drawing.Size(769, 27);
            this.m_barTools.TabIndex = 1;
            this.m_barTools.Text = "toolStrip1";
            // 
            // m_toolImport
            // 
            this.m_toolImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_toolImport.Image = ((System.Drawing.Image)(resources.GetObject("m_toolImport.Image")));
            this.m_toolImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_toolImport.Name = "m_toolImport";
            this.m_toolImport.Size = new System.Drawing.Size(24, 24);
            this.m_toolImport.Click += new System.EventHandler(this.OnCmdImport_Click);
            // 
            // m_splitter
            // 
            this.m_splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.m_splitter.Location = new System.Drawing.Point(0, 55);
            this.m_splitter.Name = "m_splitter";
            // 
            // m_splitter.Panel1
            // 
            this.m_splitter.Panel1.Controls.Add(this.m_splitterDetail);
            // 
            // m_splitter.Panel2
            // 
            this.m_splitter.Panel2.Controls.Add(this.m_panRenderPanel);
            this.m_splitter.Size = new System.Drawing.Size(769, 413);
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
            this.m_splitterDetail.Size = new System.Drawing.Size(256, 413);
            this.m_splitterDetail.SplitterDistance = 220;
            this.m_splitterDetail.TabIndex = 0;
            // 
            // m_grpLoadedFiles
            // 
            this.m_grpLoadedFiles.Controls.Add(this.m_lstIcons);
            this.m_grpLoadedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grpLoadedFiles.Location = new System.Drawing.Point(0, 0);
            this.m_grpLoadedFiles.Name = "m_grpLoadedFiles";
            this.m_grpLoadedFiles.Size = new System.Drawing.Size(256, 220);
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
            this.m_lstIcons.Size = new System.Drawing.Size(250, 199);
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
            this.m_grpProperties.Size = new System.Drawing.Size(256, 189);
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
            this.m_propSelectedFile.Size = new System.Drawing.Size(250, 168);
            this.m_propSelectedFile.TabIndex = 0;
            this.m_propSelectedFile.ToolbarVisible = false;
            // 
            // m_iconsEditor
            // 
            this.m_iconsEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.m_iconsEditor.HostControl = null;
            this.m_iconsEditor.Object001 = this.m_mnuImport;
            this.m_iconsEditor.Object001Icon = "Import";
            this.m_iconsEditor.Object002 = this.m_toolImport;
            this.m_iconsEditor.Object002Icon = "Import";
            this.m_iconsEditor.Object003 = this.m_mnuCloseAll;
            this.m_iconsEditor.Object003Icon = "Close";
            this.m_iconsEditor.Object004 = this.m_mnuImportSymbol;
            // 
            // m_dlgImportFile
            // 
            this.m_dlgImportFile.Filter = "SVG-Files (*.svg)|*.svg";
            // 
            // m_panRenderPanel
            // 
            this.m_panRenderPanel.BackColor = System.Drawing.Color.White;
            this.m_panRenderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_panRenderPanel.Location = new System.Drawing.Point(0, 0);
            this.m_panRenderPanel.Name = "m_panRenderPanel";
            this.m_panRenderPanel.Size = new System.Drawing.Size(509, 413);
            this.m_panRenderPanel.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 468);
            this.Controls.Add(this.m_splitter);
            this.Controls.Add(this.m_barTools);
            this.Controls.Add(this.m_barMainMenu);
            this.MainMenuStrip = this.m_barMainMenu;
            this.Name = "MainWindow";
            this.Text = "IconConverter";
            this.m_barMainMenu.ResumeLayout(false);
            this.m_barMainMenu.PerformLayout();
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

        private System.Windows.Forms.MenuStrip m_barMainMenu;
        private System.Windows.Forms.ToolStrip m_barTools;
        private System.Windows.Forms.SplitContainer m_splitter;
        private System.Windows.Forms.ListBox m_lstIcons;
        private System.Windows.Forms.ToolStripMenuItem m_mnuFile;
        private System.Windows.Forms.ToolStripMenuItem m_mnuImport;
        private EditorIconImageList m_iconsEditor;
        private System.Windows.Forms.ToolStripButton m_toolImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem m_mnuCloseAll;
        private System.Windows.Forms.OpenFileDialog m_dlgImportFile;
        private System.Windows.Forms.BindingSource m_dataSourceFiles;
        private System.Windows.Forms.SplitContainer m_splitterDetail;
        private System.Windows.Forms.GroupBox m_grpLoadedFiles;
        private System.Windows.Forms.GroupBox m_grpProperties;
        private System.Windows.Forms.PropertyGrid m_propSelectedFile;
        private System.Windows.Forms.ToolStripMenuItem m_mnuImportSymbol;
        private System.Windows.Forms.Panel m_panRenderPanel;
    }
}

