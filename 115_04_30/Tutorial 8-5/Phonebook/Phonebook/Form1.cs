using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    /// <summary>
    /// 電話簿項目結構 - 用於儲存每個聯絡人的名字和電話號碼
    /// </summary>
    struct PhoneBookEntry
    {
        public string name;      // 聯絡人名字
        public string phone;     // 聯絡人電話號碼
    }

    public partial class Form1 : Form
    {
        /// <summary>
        /// 儲存電話簿項目的列表
        /// 用來保存從檔案讀取的所有聯絡人資訊
        /// </summary>
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 讀取檔案方法
        /// 此方法讀取 PhoneList.txt 檔案的內容
        /// 並將其儲存為 PhoneBookEntry 物件在 phoneList 列表中
        /// </summary>
        private void ReadFile()
        {
            try
            {
                StreamReader inputFile;
                string line;
                char[] delim = { ',' };
                PhoneBookEntry entry = new PhoneBookEntry();

                // 開啟檔案
                using (inputFile = File.OpenText("PhoneList.txt"))
                {
                    // 逐行讀取檔案內容
                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine();
                        // 使用逗號分隔名字和電話號碼
                        string[] tokens = line.Split(delim);
                        // 確保每行有兩個部分（名字和電話號碼）
                        if (tokens.Length == 2)
                        {
                            entry.name = tokens[0].Trim();   // 去除名字前後的空白
                            entry.phone = tokens[1].Trim();  // 去除電話號碼前後的空白
                            // 將 entry 加入 phoneList 列表中
                            phoneList.Add(entry);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show("讀取檔案時發生錯誤: " + ex.Message);
            }
        }

        /// <summary>
        /// 顯示名字方法
        /// 此方法在 nameListBox 控制項中顯示名字列表
        /// </summary>
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                // 將每個聯絡人的名字添加到 nameListBox 中
                nameListBox.Items.Add(entry.name);
            }
        }

        /// <summary>
        /// 表單載入事件處理
        /// 當表單初次載入時執行：
        /// 1. 讀取 PhoneList.txt 檔案
        /// 2. 在列表方塊中顯示所有名字
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // 讀取電話簿檔案
            ReadFile();

            // 顯示所有名字到列表方塊
            DisplayNames();
        }

        /// <summary>
        /// 名字列表方塊選擇變更事件處理
        /// 當使用者在列表中選擇不同的名字時觸發
        /// </summary>
        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex; // 取得選擇的索引
            if (index != -1)
            {
                // 根據索引從 phoneList 中取得對應的電話號碼
                //string phone = phoneList[index].phone;
                // 顯示選擇的名字和對應的電話號碼
                //selectedPhoneDescriptionLabel.Text = "選擇的名字的電話號碼是：";
                phoneLabel.Text = phoneList[index].phone;
            }
        }

        /// <summary>
        /// 結束按鈕點擊事件處理
        /// 關閉應用程式表單
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
