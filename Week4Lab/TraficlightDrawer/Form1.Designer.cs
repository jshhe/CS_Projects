namespace TraficlightDrawer
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
            this.pictureBoxDefault = new System.Windows.Forms.PictureBox();
            this.textBoxInputSize = new System.Windows.Forms.TextBox();
            this.labelSizeInput = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefault)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDefault
            // 
            this.pictureBoxDefault.Location = new System.Drawing.Point(-1, 12);
            this.pictureBoxDefault.Name = "pictureBoxDefault";
            this.pictureBoxDefault.Size = new System.Drawing.Size(801, 946);
            this.pictureBoxDefault.TabIndex = 1;
            this.pictureBoxDefault.TabStop = false;
            // 
            // textBoxInputSize
            // 
            this.textBoxInputSize.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxInputSize.Location = new System.Drawing.Point(439, 964);
            this.textBoxInputSize.Name = "textBoxInputSize";
            this.textBoxInputSize.Size = new System.Drawing.Size(196, 53);
            this.textBoxInputSize.TabIndex = 2;
            // 
            // labelSizeInput
            // 
            this.labelSizeInput.AutoSize = true;
            this.labelSizeInput.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSizeInput.Location = new System.Drawing.Point(3, 974);
            this.labelSizeInput.Name = "labelSizeInput";
            this.labelSizeInput.Size = new System.Drawing.Size(417, 40);
            this.labelSizeInput.TabIndex = 3;
            this.labelSizeInput.Text = "Input the size here:";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDraw.Location = new System.Drawing.Point(0, 1020);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(269, 85);
            this.buttonDraw.TabIndex = 4;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClear.Location = new System.Drawing.Point(275, 1020);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(253, 85);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExit.Location = new System.Drawing.Point(534, 1020);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(266, 85);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1108);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.labelSizeInput);
            this.Controls.Add(this.textBoxInputSize);
            this.Controls.Add(this.pictureBoxDefault);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefault)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDefault;
        private System.Windows.Forms.TextBox textBoxInputSize;
        private System.Windows.Forms.Label labelSizeInput;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
    }
}

