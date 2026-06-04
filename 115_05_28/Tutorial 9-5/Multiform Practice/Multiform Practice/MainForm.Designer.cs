namespace Multiform_Practice
{
    partial class MainForm
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
            // 以下為元件初始化設定
            // 我已將所有顯示文字改為繁體中文，字型改為 18pt，並調整每個元件的大小與位置
            // 以避免在表單上出現元件遮蓋的情形。
            this.displayFormButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayFormButton
            // 
            // 設定顯示表單按鈕的位置與大小：
            // 調整寬度與高度以配合 18pt 的字型，並保留適當的間距
            this.displayFormButton.Location = new System.Drawing.Point(20, 18);
            this.displayFormButton.Name = "displayFormButton";
            this.displayFormButton.Size = new System.Drawing.Size(150, 48);
            this.displayFormButton.TabIndex = 0;
            // 將按鈕文字改為繁體中文
            this.displayFormButton.Text = "顯示表單";
            // 設定按鈕字型為繁體常用字型（微軟正黑體）18pt，確保中文字顯示美觀
            this.displayFormButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.displayFormButton.UseVisualStyleBackColor = true;
            this.displayFormButton.Click += new System.EventHandler(this.displayFormButton_Click);
            // 
            // exitButton
            // 
            // 設定離開按鈕的位置與大小，使兩個按鈕互不遮蓋且保持對齊
            this.exitButton.Location = new System.Drawing.Point(190, 18);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(110, 48);
            this.exitButton.TabIndex = 1;
            // 將按鈕文字改為繁體中文
            this.exitButton.Text = "離開";
            // 同樣設定字型為 18pt 以保持一致性
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            // 調整表單的客戶區大小以容納 18pt 字型的元件，並避免元件被裁切或重疊
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 90);
            // 將所有按鈕加入表單控制項集合，維持原本的加入順序
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayFormButton);
            this.Name = "MainForm";
            // 將表單標題改為繁體中文
            this.Text = "多表單練習";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayFormButton;
        private System.Windows.Forms.Button exitButton;
    }
}

