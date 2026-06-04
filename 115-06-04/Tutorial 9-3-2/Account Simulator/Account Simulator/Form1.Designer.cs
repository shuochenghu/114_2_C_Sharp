namespace Account_Simulator
{
    partial class Form1
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
        /// 必要的方法 - 設計工具支援 (請勿使用程式碼編輯器修改此方法內容)
        /// 以下方法會設定表單上所有元件的屬性：文字、字型、大小與位置。
        /// 已將所有元件的字型大小統一為 18，並將顯示文字改為繁體中文。
        /// 同時調整元件尺寸與位置以避免互相遮蓋。
        /// </summary>
        private void InitializeComponent()
        {
            this.depositGroupBox = new System.Windows.Forms.GroupBox();
            this.depositAccountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.depositAmounttextBox = new System.Windows.Forms.TextBox();
            this.depositAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.withdrawGroupBox = new System.Windows.Forms.GroupBox();
            this.withdrawAccountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.withdrawAmountTextBox = new System.Windows.Forms.TextBox();
            this.withdrawAmountDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceDescriptionLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.CreateAccountgroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.balancetextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.accountNumbertextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.depositGroupBox.SuspendLayout();
            this.withdrawGroupBox.SuspendLayout();
            this.CreateAccountgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositGroupBox
            // 
            this.depositGroupBox.Controls.Add(this.depositAccountTextBox);
            this.depositGroupBox.Controls.Add(this.label4);
            this.depositGroupBox.Controls.Add(this.depositButton);
            this.depositGroupBox.Controls.Add(this.depositAmounttextBox);
            this.depositGroupBox.Controls.Add(this.depositAmountDescriptionLabel);
            this.depositGroupBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositGroupBox.Location = new System.Drawing.Point(92, 343);
            this.depositGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.depositGroupBox.Name = "depositGroupBox";
            this.depositGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.depositGroupBox.Size = new System.Drawing.Size(330, 319);
            this.depositGroupBox.TabIndex = 0;
            this.depositGroupBox.TabStop = false;
            this.depositGroupBox.Text = "存款";
            this.depositGroupBox.Visible = false;
            // 
            // depositAccountTextBox
            // 
            this.depositAccountTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositAccountTextBox.Location = new System.Drawing.Point(125, 83);
            this.depositAccountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.depositAccountTextBox.Name = "depositAccountTextBox";
            this.depositAccountTextBox.Size = new System.Drawing.Size(170, 53);
            this.depositAccountTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "帳號：";
            // 
            // depositButton
            // 
            this.depositButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(111, 229);
            this.depositButton.Margin = new System.Windows.Forms.Padding(4);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(120, 55);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "存入";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // depositAmounttextBox
            // 
            this.depositAmounttextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositAmounttextBox.Location = new System.Drawing.Point(125, 157);
            this.depositAmounttextBox.Margin = new System.Windows.Forms.Padding(4);
            this.depositAmounttextBox.Name = "depositAmounttextBox";
            this.depositAmounttextBox.Size = new System.Drawing.Size(170, 53);
            this.depositAmounttextBox.TabIndex = 1;
            // 
            // depositAmountDescriptionLabel
            // 
            this.depositAmountDescriptionLabel.AutoSize = true;
            this.depositAmountDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositAmountDescriptionLabel.Location = new System.Drawing.Point(8, 164);
            this.depositAmountDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depositAmountDescriptionLabel.Name = "depositAmountDescriptionLabel";
            this.depositAmountDescriptionLabel.Size = new System.Drawing.Size(128, 46);
            this.depositAmountDescriptionLabel.TabIndex = 0;
            this.depositAmountDescriptionLabel.Text = "金額：";
            // 
            // withdrawGroupBox
            // 
            this.withdrawGroupBox.Controls.Add(this.withdrawAccountTextBox);
            this.withdrawGroupBox.Controls.Add(this.label5);
            this.withdrawGroupBox.Controls.Add(this.withdrawButton);
            this.withdrawGroupBox.Controls.Add(this.withdrawAmountTextBox);
            this.withdrawGroupBox.Controls.Add(this.withdrawAmountDescriptionLabel);
            this.withdrawGroupBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawGroupBox.Location = new System.Drawing.Point(453, 353);
            this.withdrawGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.withdrawGroupBox.Name = "withdrawGroupBox";
            this.withdrawGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.withdrawGroupBox.Size = new System.Drawing.Size(345, 309);
            this.withdrawGroupBox.TabIndex = 1;
            this.withdrawGroupBox.TabStop = false;
            this.withdrawGroupBox.Text = "提款";
            this.withdrawGroupBox.Visible = false;
            // 
            // withdrawAccountTextBox
            // 
            this.withdrawAccountTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawAccountTextBox.Location = new System.Drawing.Point(151, 73);
            this.withdrawAccountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.withdrawAccountTextBox.Name = "withdrawAccountTextBox";
            this.withdrawAccountTextBox.Size = new System.Drawing.Size(170, 53);
            this.withdrawAccountTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "帳號：";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawButton.Location = new System.Drawing.Point(107, 219);
            this.withdrawButton.Margin = new System.Windows.Forms.Padding(4);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(120, 55);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "提出";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // withdrawAmountTextBox
            // 
            this.withdrawAmountTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawAmountTextBox.Location = new System.Drawing.Point(151, 143);
            this.withdrawAmountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.withdrawAmountTextBox.Name = "withdrawAmountTextBox";
            this.withdrawAmountTextBox.Size = new System.Drawing.Size(170, 53);
            this.withdrawAmountTextBox.TabIndex = 1;
            // 
            // withdrawAmountDescriptionLabel
            // 
            this.withdrawAmountDescriptionLabel.AutoSize = true;
            this.withdrawAmountDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawAmountDescriptionLabel.Location = new System.Drawing.Point(26, 150);
            this.withdrawAmountDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.withdrawAmountDescriptionLabel.Name = "withdrawAmountDescriptionLabel";
            this.withdrawAmountDescriptionLabel.Size = new System.Drawing.Size(128, 46);
            this.withdrawAmountDescriptionLabel.TabIndex = 0;
            this.withdrawAmountDescriptionLabel.Text = "金額：";
            // 
            // balanceDescriptionLabel
            // 
            this.balanceDescriptionLabel.AutoSize = true;
            this.balanceDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceDescriptionLabel.Location = new System.Drawing.Point(825, 343);
            this.balanceDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceDescriptionLabel.Name = "balanceDescriptionLabel";
            this.balanceDescriptionLabel.Size = new System.Drawing.Size(200, 46);
            this.balanceDescriptionLabel.TabIndex = 2;
            this.balanceDescriptionLabel.Text = "帳戶資訊：";
            // 
            // balanceLabel
            // 
            this.balanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(833, 399);
            this.balanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(362, 215);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1128, 185);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 55);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CreateAccountgroupBox
            // 
            this.CreateAccountgroupBox.Controls.Add(this.button1);
            this.CreateAccountgroupBox.Controls.Add(this.balancetextBox);
            this.CreateAccountgroupBox.Controls.Add(this.nametextBox);
            this.CreateAccountgroupBox.Controls.Add(this.accountNumbertextBox);
            this.CreateAccountgroupBox.Controls.Add(this.label3);
            this.CreateAccountgroupBox.Controls.Add(this.label2);
            this.CreateAccountgroupBox.Controls.Add(this.label1);
            this.CreateAccountgroupBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CreateAccountgroupBox.Location = new System.Drawing.Point(81, 72);
            this.CreateAccountgroupBox.Name = "CreateAccountgroupBox";
            this.CreateAccountgroupBox.Size = new System.Drawing.Size(1021, 255);
            this.CreateAccountgroupBox.TabIndex = 5;
            this.CreateAccountgroupBox.TabStop = false;
            this.CreateAccountgroupBox.Text = "建立帳戶";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(602, 175);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "建立帳戶";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // balancetextBox
            // 
            this.balancetextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancetextBox.Location = new System.Drawing.Point(270, 175);
            this.balancetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.balancetextBox.Name = "balancetextBox";
            this.balancetextBox.Size = new System.Drawing.Size(300, 53);
            this.balancetextBox.TabIndex = 11;
            // 
            // nametextBox
            // 
            this.nametextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextBox.Location = new System.Drawing.Point(270, 114);
            this.nametextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(300, 53);
            this.nametextBox.TabIndex = 10;
            // 
            // accountNumbertextBox
            // 
            this.accountNumbertextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumbertextBox.Location = new System.Drawing.Point(270, 53);
            this.accountNumbertextBox.Margin = new System.Windows.Forms.Padding(4);
            this.accountNumbertextBox.Name = "accountNumbertextBox";
            this.accountNumbertextBox.Size = new System.Drawing.Size(300, 53);
            this.accountNumbertextBox.TabIndex = 9;
            this.accountNumbertextBox.TextChanged += new System.EventHandler(this.accountNumbertextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "開戶金額：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "帳號：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 787);
            this.Controls.Add(this.CreateAccountgroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.balanceDescriptionLabel);
            this.Controls.Add(this.withdrawGroupBox);
            this.Controls.Add(this.depositGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "帳戶模擬器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.depositGroupBox.ResumeLayout(false);
            this.depositGroupBox.PerformLayout();
            this.withdrawGroupBox.ResumeLayout(false);
            this.withdrawGroupBox.PerformLayout();
            this.CreateAccountgroupBox.ResumeLayout(false);
            this.CreateAccountgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox depositGroupBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox depositAmounttextBox;
        private System.Windows.Forms.Label depositAmountDescriptionLabel;
        private System.Windows.Forms.GroupBox withdrawGroupBox;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox withdrawAmountTextBox;
        private System.Windows.Forms.Label withdrawAmountDescriptionLabel;
        private System.Windows.Forms.Label balanceDescriptionLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox CreateAccountgroupBox;
        private System.Windows.Forms.TextBox balancetextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox accountNumbertextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox depositAccountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox withdrawAccountTextBox;
        private System.Windows.Forms.Label label5;
    }
}

