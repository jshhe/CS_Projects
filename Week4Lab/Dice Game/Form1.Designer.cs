namespace Dice_Game
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonAllIn = new System.Windows.Forms.Button();
            this.buttonBet = new System.Windows.Forms.Button();
            this.textBoxPlayerStack = new System.Windows.Forms.TextBox();
            this.labelStackSizeGamer = new System.Windows.Forms.Label();
            this.textBoxBet = new System.Windows.Forms.TextBox();
            this.labelcomputer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStackSizeComputer = new System.Windows.Forms.Label();
            this.textBoxComputerStack = new System.Windows.Forms.TextBox();
            this.GameSpace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExit.Location = new System.Drawing.Point(562, 463);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(356, 60);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit the game";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRestart.Location = new System.Drawing.Point(562, 397);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(356, 60);
            this.buttonRestart.TabIndex = 6;
            this.buttonRestart.Text = "Restart the game";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonAllIn
            // 
            this.buttonAllIn.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAllIn.Location = new System.Drawing.Point(562, 331);
            this.buttonAllIn.Name = "buttonAllIn";
            this.buttonAllIn.Size = new System.Drawing.Size(356, 60);
            this.buttonAllIn.TabIndex = 7;
            this.buttonAllIn.Text = "All in!";
            this.buttonAllIn.UseVisualStyleBackColor = true;
            this.buttonAllIn.Click += new System.EventHandler(this.buttonAllIn_Click);
            // 
            // buttonBet
            // 
            this.buttonBet.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBet.Location = new System.Drawing.Point(562, 265);
            this.buttonBet.Name = "buttonBet";
            this.buttonBet.Size = new System.Drawing.Size(356, 60);
            this.buttonBet.TabIndex = 8;
            this.buttonBet.Text = "Bet";
            this.buttonBet.UseVisualStyleBackColor = true;
            this.buttonBet.Click += new System.EventHandler(this.buttonBet_Click);
            // 
            // textBoxPlayerStack
            // 
            this.textBoxPlayerStack.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPlayerStack.Location = new System.Drawing.Point(502, 83);
            this.textBoxPlayerStack.Name = "textBoxPlayerStack";
            this.textBoxPlayerStack.ReadOnly = true;
            this.textBoxPlayerStack.Size = new System.Drawing.Size(303, 53);
            this.textBoxPlayerStack.TabIndex = 9;
            // 
            // labelStackSizeGamer
            // 
            this.labelStackSizeGamer.AutoSize = true;
            this.labelStackSizeGamer.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStackSizeGamer.Location = new System.Drawing.Point(5, 86);
            this.labelStackSizeGamer.Name = "labelStackSizeGamer";
            this.labelStackSizeGamer.Size = new System.Drawing.Size(377, 40);
            this.labelStackSizeGamer.TabIndex = 10;
            this.labelStackSizeGamer.Text = "Stack size of you:";
            // 
            // textBoxBet
            // 
            this.textBoxBet.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBet.Location = new System.Drawing.Point(562, 206);
            this.textBoxBet.Name = "textBoxBet";
            this.textBoxBet.Size = new System.Drawing.Size(356, 53);
            this.textBoxBet.TabIndex = 11;
            // 
            // labelcomputer
            // 
            this.labelcomputer.AutoSize = true;
            this.labelcomputer.Font = new System.Drawing.Font("宋体", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelcomputer.Location = new System.Drawing.Point(12, 155);
            this.labelcomputer.Name = "labelcomputer";
            this.labelcomputer.Size = new System.Drawing.Size(248, 56);
            this.labelcomputer.TabIndex = 12;
            this.labelcomputer.Text = "Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(402, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 56);
            this.label2.TabIndex = 13;
            this.label2.Text = "You";
            // 
            // labelStackSizeComputer
            // 
            this.labelStackSizeComputer.AutoSize = true;
            this.labelStackSizeComputer.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStackSizeComputer.Location = new System.Drawing.Point(0, 13);
            this.labelStackSizeComputer.Name = "labelStackSizeComputer";
            this.labelStackSizeComputer.Size = new System.Drawing.Size(477, 40);
            this.labelStackSizeComputer.TabIndex = 15;
            this.labelStackSizeComputer.Text = "Stack size of Computer:";
            // 
            // textBoxComputerStack
            // 
            this.textBoxComputerStack.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxComputerStack.Location = new System.Drawing.Point(502, 10);
            this.textBoxComputerStack.Name = "textBoxComputerStack";
            this.textBoxComputerStack.ReadOnly = true;
            this.textBoxComputerStack.Size = new System.Drawing.Size(303, 53);
            this.textBoxComputerStack.TabIndex = 14;
            // 
            // GameSpace
            // 
            this.GameSpace.Location = new System.Drawing.Point(7, 222);
            this.GameSpace.Name = "GameSpace";
            this.GameSpace.Size = new System.Drawing.Size(528, 299);
            this.GameSpace.TabIndex = 17;
            this.GameSpace.TabStop = false;
            this.GameSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.GameSpace_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 533);
            this.Controls.Add(this.labelcomputer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameSpace);
            this.Controls.Add(this.labelStackSizeComputer);
            this.Controls.Add(this.textBoxComputerStack);
            this.Controls.Add(this.textBoxBet);
            this.Controls.Add(this.labelStackSizeGamer);
            this.Controls.Add(this.textBoxPlayerStack);
            this.Controls.Add(this.buttonBet);
            this.Controls.Add(this.buttonAllIn);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonExit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GameSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonAllIn;
        private System.Windows.Forms.Button buttonBet;
        private System.Windows.Forms.TextBox textBoxPlayerStack;
        private System.Windows.Forms.Label labelStackSizeGamer;
        private System.Windows.Forms.TextBox textBoxBet;
        private System.Windows.Forms.Label labelcomputer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStackSizeComputer;
        private System.Windows.Forms.TextBox textBoxComputerStack;
        private System.Windows.Forms.PictureBox GameSpace;
    }
}

