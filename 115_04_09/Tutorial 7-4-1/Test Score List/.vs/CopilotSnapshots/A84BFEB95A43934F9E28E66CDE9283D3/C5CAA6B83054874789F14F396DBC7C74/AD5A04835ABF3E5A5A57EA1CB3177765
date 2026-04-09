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

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        // 建立一個 List 來儲存所有測驗成績（只儲存分數）
        List<int> scoresList = new List<int>();
        // 建立一個 List 來儲存學號與分數的完整資訊（用於顯示）
        List<string> studentRecords = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        // ReadScores：從 TestScores.txt 檔案中逐行讀取成績，並加入 List
        // 檔案格式：學號 分數（例如：A114221055 54）
        private void ReadScores(List<int> scoresList)
        {
            string filePath = "TestScores.txt"; // 成績檔案路徑
            try
            {
                // 清空兩個 List 以避免重複讀取
                scoresList.Clear();
                studentRecords.Clear();

                // 開啟檔案進行讀取
                using (StreamReader reader = File.OpenText(filePath))
                {
                    // 逐行讀取直到檔案結尾
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine(); // 讀取一行資料
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            // 使用空白字元分割學號和分數
                            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            
                            if (parts.Length >= 2)
                            {
                                string studentId = parts[0]; // 取得學號
                                int score;
                                
                                // 嘗試將分數部分轉換為整數
                                if (int.TryParse(parts[1], out score))
                                {
                                    scoresList.Add(score); // 將分數加入 scoresList
                                    studentRecords.Add(studentId + " " + score); // 將完整資訊加入 studentRecords
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // 若讀取失敗則顯示錯誤訊息
                MessageBox.Show("讀取成績時發生錯誤：" + ex.Message);
            }
        }

        // DisplayScores：將學號與分數的完整資訊逐一加入 ListBox 顯示
        private void DisplayScores(List<int> scoresList)
        {
            // 使用 studentRecords 來顯示學號和分數
            foreach (string record in studentRecords)
            {
                testScoresListBox.Items.Add(record);
            }
        }

        // Average：計算並回傳 List 中所有成績的平均值
        private double Average(List<int> scoresList)
        {
            int total = 0;

            // 累加所有成績
            foreach (int score in scoresList)
            {
                total += score;
            }

            // 回傳平均值（總分除以成績筆數）
            return (double)total / scoresList.Count;
        }

        // AboveAverage：計算並回傳高於平均值的成績數量
        private int AboveAverage(List<int> scoresList, double avg)
        {
            int count = 0;

            foreach (int score in scoresList)
            {
                // 若成績大於平均值，計數器加 1
                if (score > avg)
                    count++;
            }

            return count;
        }

        // BelowAverage：計算並回傳低於平均值的成績數量
        private int BelowAverage(List<int> scoresList)
        {
            int count = 0;
            double avg = Average(scoresList);

            foreach (int score in scoresList)
            {
                // 若成績小於平均值，計數器加 1
                if (score < avg)
                    count++;
            }

            return count;
        }

        // getScoresButton_Click：「取得成績」按鈕的點擊事件處理方法
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;    // 用來儲存平均成績
            int numAboveAverage;    // 用來儲存高於平均的成績數量
            int numBelowAverage;    // 用來儲存低於平均的成績數量

            // 建立一個 List 來儲存所有測驗成績
            //List<int> scoresList = new List<int>();

            // 從檔案中讀取成績並存入 List
            ReadScores(scoresList);

            // 在 ListBox 中顯示所有成績
            DisplayScores(scoresList);

            // 計算並顯示平均成績
            averageScore = Average(scoresList);
            averageLabel.Text = averageScore.ToString("n1");

            // 計算並顯示高於平均的成績數量
            numAboveAverage = AboveAverage(scoresList, averageScore);
            aboveAverageLabel.Text = numAboveAverage.ToString();

            // 計算並顯示低於平均的成績數量
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString();
        }

        // searchButton_Click：「搜尋」按鈕的點擊事件處理方法
        // 在 List 中搜尋使用者輸入的成績
        // 搜尋成功則顯示所在位置與學號，失敗則顯示「分數不存在」
        private void searchButton_Click(object sender, EventArgs e)
        {
            int searchScore;    // 用來儲存使用者輸入的搜尋成績
            int position;       // 用來儲存搜尋到的成績位置

            // 嘗試將輸入框的文字轉換為整數，若失敗則提示使用者
            if (!int.TryParse(searchTextBox.Text, out searchScore))
            {
                searchResultLabel.Text = "請輸入有效的整數成績";
                return;
            }

            // 在 scoresList 中搜尋使用者輸入的成績，若找到則回傳位置，否則回傳 -1
            if ((position = scoresList.IndexOf(searchScore)) != -1)
            {
                // 從 studentRecords 取得對應的完整資訊（學號 分數）
                string record = studentRecords[position];
                searchResultLabel.Text = $"分數 {searchScore} 位於第 {position + 1} 筆 ({record})";
                return;
            }
            else
            {
                searchResultLabel.Text = "分數不存在";
                return;
            }
        }

        // exitButton_Click：「離開」按鈕的點擊事件處理方法
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單並結束應用程式
            this.Close();
        }
    }
}

