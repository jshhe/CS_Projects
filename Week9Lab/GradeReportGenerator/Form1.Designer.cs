namespace GradeReportGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseOriginFile = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPictureBox = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportReport = new System.Windows.Forms.ToolStripMenuItem();
            this.Kill = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox = new System.Windows.Forms.ListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1918, 32);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseOriginFile,
            this.DrawPicture,
            this.clearPictureBox,
            this.ExportReport,
            this.Kill});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(76, 28);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ChooseOriginFile
            // 
            this.ChooseOriginFile.Name = "ChooseOriginFile";
            this.ChooseOriginFile.Size = new System.Drawing.Size(270, 34);
            this.ChooseOriginFile.Text = "Choose File";
            this.ChooseOriginFile.Click += new System.EventHandler(this.ChooseOriginFile_Click);
            // 
            // DrawPicture
            // 
            this.DrawPicture.Name = "DrawPicture";
            this.DrawPicture.Size = new System.Drawing.Size(270, 34);
            this.DrawPicture.Text = "Draw  a Picture";
            this.DrawPicture.Click += new System.EventHandler(this.DrawPicture_Click);
            // 
            // clearPictureBox
            // 
            this.clearPictureBox.Name = "clearPictureBox";
            this.clearPictureBox.Size = new System.Drawing.Size(270, 34);
            this.clearPictureBox.Text = "Clear";
            this.clearPictureBox.Click += new System.EventHandler(this.clearPictureBox_Click);
            // 
            // ExportReport
            // 
            this.ExportReport.Name = "ExportReport";
            this.ExportReport.Size = new System.Drawing.Size(270, 34);
            this.ExportReport.Text = "Export Report";
            this.ExportReport.Click += new System.EventHandler(this.ExportReport_Click);
            // 
            // Kill
            // 
            this.Kill.Name = "Kill";
            this.Kill.Size = new System.Drawing.Size(270, 34);
            this.Kill.Text = "Exit";
            this.Kill.Click += new System.EventHandler(this.Kill_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(12, 100);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(200, 598);
            this.listBox.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(259, 100);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1644, 600);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 714);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChooseOriginFile;
        private System.Windows.Forms.ToolStripMenuItem DrawPicture;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem clearPictureBox;
        private System.Windows.Forms.ToolStripMenuItem ExportReport;
        private System.Windows.Forms.ToolStripMenuItem Kill;
    }
}

