namespace IconLibrary.WinFormsSample
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
            this.m_cmdClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.m_toolBar = new System.Windows.Forms.ToolStrip();
            this.m_toolOpen = new System.Windows.Forms.ToolStripButton();
            this.m_toolSave = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.m_iconsEditor = new IconLibrary.EditorIconImageList(this.components);
            this.m_iconsVector = new IconLibrary.VectorIconImageList(this.components);
            this.m_toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cmdClose
            // 
            this.m_cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_cmdClose.Image = ((System.Drawing.Image)(resources.GetObject("m_cmdClose.Image")));
            this.m_cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmdClose.Location = new System.Drawing.Point(293, 248);
            this.m_cmdClose.Name = "m_cmdClose";
            this.m_cmdClose.Size = new System.Drawing.Size(139, 40);
            this.m_cmdClose.TabIndex = 0;
            this.m_cmdClose.Text = "button1";
            this.m_cmdClose.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(438, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // m_toolBar
            // 
            this.m_toolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_toolOpen,
            this.m_toolSave});
            this.m_toolBar.Location = new System.Drawing.Point(0, 0);
            this.m_toolBar.Name = "m_toolBar";
            this.m_toolBar.Size = new System.Drawing.Size(589, 27);
            this.m_toolBar.TabIndex = 2;
            this.m_toolBar.Text = "toolStrip1";
            // 
            // m_toolOpen
            // 
            this.m_toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_toolOpen.Image = ((System.Drawing.Image)(resources.GetObject("m_toolOpen.Image")));
            this.m_toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_toolOpen.Name = "m_toolOpen";
            this.m_toolOpen.Size = new System.Drawing.Size(24, 24);
            this.m_toolOpen.Text = "Open";
            // 
            // m_toolSave
            // 
            this.m_toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_toolSave.Image = ((System.Drawing.Image)(resources.GetObject("m_toolSave.Image")));
            this.m_toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_toolSave.Name = "m_toolSave";
            this.m_toolSave.Size = new System.Drawing.Size(24, 24);
            this.m_toolSave.Text = "Save";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(75, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 88);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(239, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 88);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // m_iconsEditor
            // 
            this.m_iconsEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.m_iconsEditor.HostControl = null;
            this.m_iconsEditor.Object001 = this.m_cmdClose;
            this.m_iconsEditor.Object001Icon = "Close";
            this.m_iconsEditor.Object003 = this.m_toolSave;
            this.m_iconsEditor.Object003Icon = "Save";
            this.m_iconsEditor.Object005 = this.m_toolOpen;
            this.m_iconsEditor.Object005Icon = "Open";
            this.m_iconsEditor.Object006 = this.button1;
            this.m_iconsEditor.Object006Icon = "ModelEdit";
            // 
            // m_iconsVector
            // 
            this.m_iconsVector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.m_iconsVector.HostControl = this;
            this.m_iconsVector.ImageSideWidth = 32;
            this.m_iconsVector.Object001 = this.button2;
            this.m_iconsVector.Object002 = this.button3;
            this.m_iconsVector.Object002Icon = "TruckMove";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 300);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_toolBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_cmdClose);
            this.Name = "MainWindow";
            this.Text = "IconLibrary - Win.Forms";
            this.m_toolBar.ResumeLayout(false);
            this.m_toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_cmdClose;
        private System.Windows.Forms.Button button1;
        private EditorIconImageList m_iconsEditor;
        private System.Windows.Forms.ToolStrip m_toolBar;
        private System.Windows.Forms.ToolStripButton m_toolOpen;
        private System.Windows.Forms.ToolStripButton m_toolSave;
        private System.Windows.Forms.Button button2;
        private VectorIconImageList m_iconsVector;
        private System.Windows.Forms.Button button3;
    }
}

