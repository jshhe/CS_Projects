namespace Chlorine_Cost_Calculater__GUIonly_
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
            this.components = new System.ComponentModel.Container();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelRadius = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelWaterVolume = new System.Windows.Forms.Label();
            this.labelChlorinerequired = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelRequiredbag = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.textBoxBag = new System.Windows.Forms.TextBox();
            this.textBoxKilo = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDepth.Location = new System.Drawing.Point(45, 51);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(287, 33);
            this.labelDepth.TabIndex = 0;
            this.labelDepth.Text = "Depth of the pool";
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRadius.Location = new System.Drawing.Point(45, 140);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(303, 33);
            this.labelRadius.TabIndex = 1;
            this.labelRadius.Text = "Radius of the pool";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCalculate.Location = new System.Drawing.Point(51, 226);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(281, 57);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Caculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExit.Location = new System.Drawing.Point(593, 778);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(281, 57);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelWaterVolume
            // 
            this.labelWaterVolume.AutoSize = true;
            this.labelWaterVolume.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWaterVolume.Location = new System.Drawing.Point(45, 420);
            this.labelWaterVolume.Name = "labelWaterVolume";
            this.labelWaterVolume.Size = new System.Drawing.Size(255, 33);
            this.labelWaterVolume.TabIndex = 4;
            this.labelWaterVolume.Text = "Volume of water";
            // 
            // labelChlorinerequired
            // 
            this.labelChlorinerequired.AutoSize = true;
            this.labelChlorinerequired.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelChlorinerequired.Location = new System.Drawing.Point(45, 505);
            this.labelChlorinerequired.Name = "labelChlorinerequired";
            this.labelChlorinerequired.Size = new System.Drawing.Size(351, 33);
            this.labelChlorinerequired.TabIndex = 5;
            this.labelChlorinerequired.Text = "Chlorine required(Kg)";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCost.Location = new System.Drawing.Point(45, 675);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(255, 33);
            this.labelCost.TabIndex = 7;
            this.labelCost.Text = "Cost of colrine";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClear.Location = new System.Drawing.Point(51, 322);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(281, 57);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelRequiredbag
            // 
            this.labelRequiredbag.AutoSize = true;
            this.labelRequiredbag.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRequiredbag.Location = new System.Drawing.Point(45, 595);
            this.labelRequiredbag.Name = "labelRequiredbag";
            this.labelRequiredbag.Size = new System.Drawing.Size(367, 33);
            this.labelRequiredbag.TabIndex = 9;
            this.labelRequiredbag.Text = "Chlorine required(Bag)";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxDepth
            // 
            this.textBoxDepth.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxDepth.Location = new System.Drawing.Point(410, 51);
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.Size = new System.Drawing.Size(228, 44);
            this.textBoxDepth.TabIndex = 11;
            // 
            // textBoxBag
            // 
            this.textBoxBag.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBag.Location = new System.Drawing.Point(410, 592);
            this.textBoxBag.Name = "textBoxBag";
            this.textBoxBag.ReadOnly = true;
            this.textBoxBag.Size = new System.Drawing.Size(228, 44);
            this.textBoxBag.TabIndex = 12;
            // 
            // textBoxKilo
            // 
            this.textBoxKilo.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxKilo.Location = new System.Drawing.Point(410, 502);
            this.textBoxKilo.Name = "textBoxKilo";
            this.textBoxKilo.ReadOnly = true;
            this.textBoxKilo.Size = new System.Drawing.Size(228, 44);
            this.textBoxKilo.TabIndex = 13;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxVolume.Location = new System.Drawing.Point(410, 420);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.ReadOnly = true;
            this.textBoxVolume.Size = new System.Drawing.Size(228, 44);
            this.textBoxVolume.TabIndex = 14;
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRadius.Location = new System.Drawing.Point(410, 140);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(228, 44);
            this.textBoxRadius.TabIndex = 15;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCost.Location = new System.Drawing.Point(410, 672);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(228, 44);
            this.textBoxCost.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 833);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.textBoxKilo);
            this.Controls.Add(this.textBoxBag);
            this.Controls.Add(this.textBoxDepth);
            this.Controls.Add(this.labelRequiredbag);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelChlorinerequired);
            this.Controls.Add(this.labelWaterVolume);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.labelDepth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelWaterVolume;
        private System.Windows.Forms.Label labelChlorinerequired;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelRequiredbag;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.TextBox textBoxBag;
        private System.Windows.Forms.TextBox textBoxKilo;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.TextBox textBoxCost;
    }
}

