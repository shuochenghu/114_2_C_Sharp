namespace Program8_12
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_depositPrompt = new System.Windows.Forms.Label();
            this.textBox_deposit = new System.Windows.Forms.TextBox();
            this.button_deposit = new System.Windows.Forms.Button();
            this.label_balance = new System.Windows.Forms.Label();
            this.label_lastWin = new System.Windows.Forms.Label();
            this.label_betPrompt = new System.Windows.Forms.Label();
            this.comboBox_bet = new System.Windows.Forms.ComboBox();
            this.label_totalSpins = new System.Windows.Forms.Label();
            this.label_winCount = new System.Windows.Forms.Label();
            this.label_winRate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Apple.bmp");
            this.imageList1.Images.SetKeyName(1, "Banana.bmp");
            this.imageList1.Images.SetKeyName(2, "Cherries.bmp");
            this.imageList1.Images.SetKeyName(3, "Grapes.bmp");
            this.imageList1.Images.SetKeyName(4, "Lemon.bmp");
            this.imageList1.Images.SetKeyName(5, "Lime.bmp");
            this.imageList1.Images.SetKeyName(6, "Orange.bmp");
            this.imageList1.Images.SetKeyName(7, "Pear.bmp");
            this.imageList1.Images.SetKeyName(8, "Strawberry.bmp");
            this.imageList1.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(65, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(205, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(345, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label_depositPrompt
            // 
            this.label_depositPrompt.AutoSize = true;
            this.label_depositPrompt.Location = new System.Drawing.Point(63, 25);
            this.label_depositPrompt.Name = "label_depositPrompt";
            this.label_depositPrompt.Size = new System.Drawing.Size(221, 45);
            this.label_depositPrompt.TabIndex = 3;
            this.label_depositPrompt.Text = "存入金額：$";
            // 
            // textBox_deposit
            // 
            this.textBox_deposit.Location = new System.Drawing.Point(235, 20);
            this.textBox_deposit.Name = "textBox_deposit";
            this.textBox_deposit.Size = new System.Drawing.Size(290, 55);
            this.textBox_deposit.TabIndex = 4;
            // 
            // button_deposit
            // 
            this.button_deposit.Location = new System.Drawing.Point(582, 12);
            this.button_deposit.Name = "button_deposit";
            this.button_deposit.Size = new System.Drawing.Size(196, 74);
            this.button_deposit.TabIndex = 5;
            this.button_deposit.Text = "存入";
            this.button_deposit.UseVisualStyleBackColor = true;
            this.button_deposit.Click += new System.EventHandler(this.button_deposit_Click);
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Location = new System.Drawing.Point(63, 80);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(220, 45);
            this.label_balance.TabIndex = 6;
            this.label_balance.Text = "餘額：$0.00";
            // 
            // label_lastWin
            // 
            this.label_lastWin.AutoSize = true;
            this.label_lastWin.Location = new System.Drawing.Point(300, 80);
            this.label_lastWin.Name = "label_lastWin";
            this.label_lastWin.Size = new System.Drawing.Size(292, 45);
            this.label_lastWin.TabIndex = 7;
            this.label_lastWin.Text = "本次獲得：$0.00";
            // 
            // label_betPrompt
            // 
            this.label_betPrompt.AutoSize = true;
            this.label_betPrompt.Location = new System.Drawing.Point(63, 268);
            this.label_betPrompt.Name = "label_betPrompt";
            this.label_betPrompt.Size = new System.Drawing.Size(200, 45);
            this.label_betPrompt.TabIndex = 8;
            this.label_betPrompt.Text = "下注金額：";
            // 
            // comboBox_bet
            // 
            this.comboBox_bet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bet.FormattingEnabled = true;
            this.comboBox_bet.Location = new System.Drawing.Point(203, 263);
            this.comboBox_bet.Name = "comboBox_bet";
            this.comboBox_bet.Size = new System.Drawing.Size(130, 53);
            this.comboBox_bet.TabIndex = 9;
            this.comboBox_bet.SelectedIndexChanged += new System.EventHandler(this.comboBox_bet_SelectedIndexChanged);
            // 
            // label_totalSpins
            // 
            this.label_totalSpins.AutoSize = true;
            this.label_totalSpins.Location = new System.Drawing.Point(15, 322);
            this.label_totalSpins.Name = "label_totalSpins";
            this.label_totalSpins.Size = new System.Drawing.Size(194, 45);
            this.label_totalSpins.TabIndex = 10;
            this.label_totalSpins.Text = "旋轉：0 次";
            // 
            // label_winCount
            // 
            this.label_winCount.AutoSize = true;
            this.label_winCount.Location = new System.Drawing.Point(190, 322);
            this.label_winCount.Name = "label_winCount";
            this.label_winCount.Size = new System.Drawing.Size(194, 45);
            this.label_winCount.TabIndex = 11;
            this.label_winCount.Text = "中獎：0 次";
            // 
            // label_winRate
            // 
            this.label_winRate.AutoSize = true;
            this.label_winRate.Location = new System.Drawing.Point(365, 322);
            this.label_winRate.Name = "label_winRate";
            this.label_winRate.Size = new System.Drawing.Size(210, 45);
            this.label_winRate.TabIndex = 12;
            this.label_winRate.Text = "勝率：0.0%";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(115, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "旋轉";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "離開";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1480, 1043);
            this.Controls.Add(this.label_depositPrompt);
            this.Controls.Add(this.textBox_deposit);
            this.Controls.Add(this.button_deposit);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.label_lastWin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label_betPrompt);
            this.Controls.Add(this.comboBox_bet);
            this.Controls.Add(this.label_totalSpins);
            this.Controls.Add(this.label_winCount);
            this.Controls.Add(this.label_winRate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "吃角子老虎機";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 控制項宣告
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_depositPrompt;
        private System.Windows.Forms.TextBox textBox_deposit;
        private System.Windows.Forms.Button button_deposit;
        private System.Windows.Forms.Label label_balance;       // 即時餘額
        private System.Windows.Forms.Label label_lastWin;       // 本次獲得
        private System.Windows.Forms.Label label_betPrompt;
        private System.Windows.Forms.ComboBox comboBox_bet;
        private System.Windows.Forms.Label label_totalSpins;    // 旋轉次數
        private System.Windows.Forms.Label label_winCount;      // 中獎次數
        private System.Windows.Forms.Label label_winRate;       // 勝率
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
