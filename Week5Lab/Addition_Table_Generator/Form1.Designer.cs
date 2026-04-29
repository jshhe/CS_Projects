namespace Addition_Table_Generator
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
            this.textBoxLines = new System.Windows.Forms.TextBox();
            this.textBoxAN = new System.Windows.Forms.TextBox();
            this.labelATG = new System.Windows.Forms.Label();
            this.labelLines = new System.Windows.Forms.Label();
            this.labelAN = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLines
            // 
            this.textBoxLines.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxLines.Location = new System.Drawing.Point(360, 215);
            this.textBoxLines.Name = "textBoxLines";
            this.textBoxLines.Size = new System.Drawing.Size(100, 53);
            this.textBoxLines.TabIndex = 1;
            // 
            // textBoxAN
            // 
            this.textBoxAN.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAN.Location = new System.Drawing.Point(360, 139);
            this.textBoxAN.Name = "textBoxAN";
            this.textBoxAN.Size = new System.Drawing.Size(100, 53);
            this.textBoxAN.TabIndex = 2;
            // 
            // labelATG
            // 
            this.labelATG.AutoSize = true;
            this.labelATG.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelATG.Location = new System.Drawing.Point(12, 9);
            this.labelATG.Name = "labelATG";
            this.labelATG.Size = new System.Drawing.Size(497, 40);
            this.labelATG.TabIndex = 3;
            this.labelATG.Text = "Addition Table Generator";
            // 
            // labelLines
            // 
            this.labelLines.AutoSize = true;
            this.labelLines.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLines.Location = new System.Drawing.Point(8, 228);
            this.labelLines.Name = "labelLines";
            this.labelLines.Size = new System.Drawing.Size(117, 40);
            this.labelLines.TabIndex = 4;
            this.labelLines.Text = "Lines";
            // 
            // labelAN
            // 
            this.labelAN.AutoSize = true;
            this.labelAN.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAN.Location = new System.Drawing.Point(8, 152);
            this.labelAN.Name = "labelAN";
            this.labelAN.Size = new System.Drawing.Size(317, 40);
            this.labelAN.TabIndex = 5;
            this.labelAN.Text = "Addition Number";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonGenerate.Location = new System.Drawing.Point(15, 314);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(210, 52);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExit.Location = new System.Drawing.Point(254, 314);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(206, 52);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 389);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelAN);
            this.Controls.Add(this.labelLines);
            this.Controls.Add(this.labelATG);
            this.Controls.Add(this.textBoxAN);
            this.Controls.Add(this.textBoxLines);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLines;
        private System.Windows.Forms.TextBox textBoxAN;
        private System.Windows.Forms.Label labelATG;
        private System.Windows.Forms.Label labelLines;
        private System.Windows.Forms.Label labelAN;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonExit;
    }
}

