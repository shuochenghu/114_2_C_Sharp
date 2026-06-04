namespace Tutorial_9_3_3
{
    partial class DepositForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        // 標籤控制項
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label resultLabel;
        
        // 文字輸入框
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        
        // 按鈕
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button exitButton;

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
            this.titleLabel = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(118, 48);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "存款";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.accountNumberLabel.Location = new System.Drawing.Point(60, 100);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(110, 32);
            this.accountNumberLabel.TabIndex = 1;
            this.accountNumberLabel.Text = "帳號：";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.amountLabel.Location = new System.Drawing.Point(60, 155);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(110, 32);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "金額：";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.accountNumberTextBox.Location = new System.Drawing.Point(260, 95);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(300, 41);
            this.accountNumberTextBox.TabIndex = 2;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.amountTextBox.Location = new System.Drawing.Point(260, 150);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(300, 41);
            this.amountTextBox.TabIndex = 4;
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.depositButton.Location = new System.Drawing.Point(260, 210);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(120, 40);
            this.depositButton.TabIndex = 5;
            this.depositButton.Text = "存入";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(400, 210);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 40);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabel.Location = new System.Drawing.Point(20, 280);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(540, 136);
            this.resultLabel.TabIndex = 7;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 452);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "DepositForm";
            this.Text = "存款";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}