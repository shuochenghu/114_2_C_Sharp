namespace Tutorial_9_3_3
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button openAccountButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button exitButton;
        
        // 用戶統計標籤
        private System.Windows.Forms.Label userCountLabel;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openAccountButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.userCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openAccountButton
            // 
            this.openAccountButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.openAccountButton.Location = new System.Drawing.Point(50, 40);
            this.openAccountButton.Name = "openAccountButton";
            this.openAccountButton.Size = new System.Drawing.Size(180, 60);
            this.openAccountButton.TabIndex = 0;
            this.openAccountButton.Text = "開戶";
            this.openAccountButton.UseVisualStyleBackColor = true;
            this.openAccountButton.Click += new System.EventHandler(this.openAccountButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.depositButton.Location = new System.Drawing.Point(302, 40);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(180, 60);
            this.depositButton.TabIndex = 1;
            this.depositButton.Text = "存款";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.withdrawButton.Location = new System.Drawing.Point(548, 40);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(180, 60);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "提款";
            this.withdrawButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(281, 182);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 60);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userCountLabel
            // 
            this.userCountLabel.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userCountLabel.Location = new System.Drawing.Point(409, 298);
            this.userCountLabel.Name = "userCountLabel";
            this.userCountLabel.Size = new System.Drawing.Size(93, 50);
            this.userCountLabel.TabIndex = 4;
            this.userCountLabel.Text = "0";
            this.userCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(187, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "已開戶用戶數：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userCountLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.openAccountButton);
            this.Name = "MainForm";
            this.Text = "銀行系統";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}

