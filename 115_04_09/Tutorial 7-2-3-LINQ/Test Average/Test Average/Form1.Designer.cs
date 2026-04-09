namespace Test_Average
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.averageScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.lowScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.highScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.testScoresDescriptionLabel = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.lowScoreLabel = new System.Windows.Forms.Label();
            this.averageScoreLabel = new System.Windows.Forms.Label();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // averageScoreDescriptionLabel
            // 
            this.averageScoreDescriptionLabel.AutoSize = true;
            this.averageScoreDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.averageScoreDescriptionLabel.Location = new System.Drawing.Point(865, 255);
            this.averageScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageScoreDescriptionLabel.Name = "averageScoreDescriptionLabel";
            this.averageScoreDescriptionLabel.Size = new System.Drawing.Size(161, 40);
            this.averageScoreDescriptionLabel.TabIndex = 9;
            this.averageScoreDescriptionLabel.Text = "平均分數";
            // 
            // lowScoreDescriptionLabel
            // 
            this.lowScoreDescriptionLabel.AutoSize = true;
            this.lowScoreDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lowScoreDescriptionLabel.Location = new System.Drawing.Point(865, 165);
            this.lowScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowScoreDescriptionLabel.Name = "lowScoreDescriptionLabel";
            this.lowScoreDescriptionLabel.Size = new System.Drawing.Size(161, 40);
            this.lowScoreDescriptionLabel.TabIndex = 8;
            this.lowScoreDescriptionLabel.Text = "最低分數";
            // 
            // highScoreDescriptionLabel
            // 
            this.highScoreDescriptionLabel.AutoSize = true;
            this.highScoreDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.highScoreDescriptionLabel.Location = new System.Drawing.Point(865, 75);
            this.highScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highScoreDescriptionLabel.Name = "highScoreDescriptionLabel";
            this.highScoreDescriptionLabel.Size = new System.Drawing.Size(161, 40);
            this.highScoreDescriptionLabel.TabIndex = 7;
            this.highScoreDescriptionLabel.Text = "最高分數";
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.ItemHeight = 40;
            this.testScoresListBox.Location = new System.Drawing.Point(22, 55);
            this.testScoresListBox.Margin = new System.Windows.Forms.Padding(4);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(763, 244);
            this.testScoresListBox.TabIndex = 6;
            // 
            // testScoresDescriptionLabel
            // 
            this.testScoresDescriptionLabel.AutoSize = true;
            this.testScoresDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.testScoresDescriptionLabel.Location = new System.Drawing.Point(22, 11);
            this.testScoresDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testScoresDescriptionLabel.Name = "testScoresDescriptionLabel";
            this.testScoresDescriptionLabel.Size = new System.Drawing.Size(161, 40);
            this.testScoresDescriptionLabel.TabIndex = 5;
            this.testScoresDescriptionLabel.Text = "測驗分數";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.highScoreLabel.Location = new System.Drawing.Point(1060, 68);
            this.highScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(194, 55);
            this.highScoreLabel.TabIndex = 10;
            this.highScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowScoreLabel
            // 
            this.lowScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lowScoreLabel.Location = new System.Drawing.Point(1060, 158);
            this.lowScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowScoreLabel.Name = "lowScoreLabel";
            this.lowScoreLabel.Size = new System.Drawing.Size(194, 55);
            this.lowScoreLabel.TabIndex = 11;
            this.lowScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageScoreLabel
            // 
            this.averageScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.averageScoreLabel.Location = new System.Drawing.Point(1060, 248);
            this.averageScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageScoreLabel.Name = "averageScoreLabel";
            this.averageScoreLabel.Size = new System.Drawing.Size(194, 55);
            this.averageScoreLabel.TabIndex = 12;
            this.averageScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getScoresButton
            // 
            this.getScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.getScoresButton.Location = new System.Drawing.Point(248, 407);
            this.getScoresButton.Margin = new System.Windows.Forms.Padding(4);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(225, 62);
            this.getScoresButton.TabIndex = 13;
            this.getScoresButton.Text = "取得分數";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(893, 407);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(165, 62);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 539);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averageScoreLabel);
            this.Controls.Add(this.lowScoreLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.averageScoreDescriptionLabel);
            this.Controls.Add(this.lowScoreDescriptionLabel);
            this.Controls.Add(this.highScoreDescriptionLabel);
            this.Controls.Add(this.testScoresListBox);
            this.Controls.Add(this.testScoresDescriptionLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "測驗平均分數";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label averageScoreDescriptionLabel;
        private System.Windows.Forms.Label lowScoreDescriptionLabel;
        private System.Windows.Forms.Label highScoreDescriptionLabel;
        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label testScoresDescriptionLabel;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label lowScoreLabel;
        private System.Windows.Forms.Label averageScoreLabel;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
    }
}

