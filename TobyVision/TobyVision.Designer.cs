namespace TobyVision
{
    partial class TobyVision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TobyVision));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanningYNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbViewer = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanningYNToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.testToolStripMenuItem.Text = "Scan";
            // 
            // scanningYNToolStripMenuItem
            // 
            this.scanningYNToolStripMenuItem.Name = "scanningYNToolStripMenuItem";
            this.scanningYNToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.scanningYNToolStripMenuItem.Text = "Scanning? (Y /N)";
            this.scanningYNToolStripMenuItem.Click += new System.EventHandler(this.scanningYNToolStripMenuItem_Click);
            // 
            // pbViewer
            // 
            this.pbViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbViewer.Image = ((System.Drawing.Image)(resources.GetObject("pbViewer.Image")));
            this.pbViewer.Location = new System.Drawing.Point(0, 24);
            this.pbViewer.Name = "pbViewer";
            this.pbViewer.Size = new System.Drawing.Size(1024, 725);
            this.pbViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbViewer.TabIndex = 1;
            this.pbViewer.TabStop = false;
            this.pbViewer.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawRectangle);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TobyVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbViewer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TobyVision";
            this.Text = "TobyVision";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TobyVision_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbViewer;
        private System.Windows.Forms.ToolStripMenuItem scanningYNToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

