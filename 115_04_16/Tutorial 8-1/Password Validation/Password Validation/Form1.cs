using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// NumberUpperCase 方法接受字串引數，並返回其包含的大寫字母數量。
        /// </summary>
        /// <param name="str">待檢查的字串</param>
        /// <returns>字串中大寫字母的數量</returns>
        private int NumberUpperCase(string str)
        {
            int count = 0; // 初始化計數器
            foreach (char c in str) // 遍歷字串中的每個字元
            {
                if (char.IsUpper(c)) // 如果字元是大寫字母
                {
                    count++; // 增加計數器
                }
            }
            return count; // 返回大寫字母的數量
        }

        /// <summary>
        /// NumberLowerCase 方法接受字串引數，並返回其包含的小寫字母數量。
        /// </summary>
        /// <param name="str">待檢查的字串</param>
        /// <returns>字串中小寫字母的數量</returns>
        private int NumberLowerCase(string str)
        {
            int count = 0; // 初始化計數器
            foreach (var item in str)   
            {
                if (char.IsLower(item)) // 如果字元是小寫字母
                {
                    count++; // 增加計數器
                }
            }
            return count; // 返回小寫字母的數量  
        }

        /// <summary>
        /// NumberDigits 方法接受字串引數，並返回其包含的數字位數。
        /// </summary>
        /// <param name="str">待檢查的字串</param>
        /// <returns>字串中數字的數量</returns>
        private int NumberDigits(string str)
        {
            int count = 0; // 初始化計數器
            foreach (char c in str) // 遍歷字串中的每個字元
            {
                if (char.IsDigit(c)) // 如果字元是數字
                {
                    count++; // 增加計數器
                }
            }
            return count; // 返回數字的數量
        }

        /// <summary>
        /// 檢查密碼按鈕的點擊事件處理程序。
        /// 驗證使用者輸入的密碼是否符合所有要求。
        /// </summary>
        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8; // 密碼的最小長度要求
            string password = passwordTextBox.Text; // 從文本框獲取使用者輸入的密碼
            if (password.Length < MIN_LENGTH)
            {
                MessageBox.Show("密碼長度至少須為 8 個字元。");
                return;
            }
            else
            {
                int upperCaseCount = NumberUpperCase(password);
                int lowerCaseCount = NumberLowerCase(password);
                int digitCount = NumberDigits(password);
                if (upperCaseCount < 1)
                {
                    MessageBox.Show("密碼必須至少包含一個大寫字母。");
                    return;
                }
                else if (lowerCaseCount < 1)
                {
                    MessageBox.Show("密碼必須至少包含一個小寫字母。");
                    return;
                }
                else if (digitCount < 1)
                {
                    MessageBox.Show("密碼必須至少包含一個數字。");
                    return;
                }
                else
                {
                    MessageBox.Show("密碼有效！");
                }
            }

        }

        /// <summary>
        /// 結束按鈕的點擊事件處理程序。
        /// 關閉表單。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
