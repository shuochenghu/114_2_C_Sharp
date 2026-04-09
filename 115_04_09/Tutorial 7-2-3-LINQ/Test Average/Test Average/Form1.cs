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

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Average 方法接受一個整數陣列作為參數
        // 並返回該陣列中所有數值的平均值
        // 使用 LINQ 查詢語法計算平均值
        private double Average(int[] sArray)
        {
            var averageQuery = from score in sArray
                               select score;
            
            return averageQuery.Average();
        }

        // Highest 方法接受一個整數陣列作為參數
        // 並返回該陣列中的最高值
        // 使用 LINQ 查詢語法找出最高分
        private int Highest(int[] sArray)
        {
            var highestQuery = from score in sArray
                               orderby score descending
                               select score;
            
            return highestQuery.First();
        }

        // Lowest 方法接受一個整數陣列作為參數
        // 並返回該陣列中的最低值
        // 使用 LINQ 查詢語法找出最低分
        private int Lowest(int[] sArray)
        {
            var lowestQuery = from score in sArray
                              orderby score ascending
                              select score;
            
            return lowestQuery.First();
        }

        private int getFileScoreCount()
        {
            int count = 0;
            StreamReader inputFile;
            try
            {
                inputFile = File.OpenText("TestScores.txt");
                while (!inputFile.EndOfStream)
                {
                    inputFile.ReadLine();
                    count++;
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show(ex.Message);
            }
            return count;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            // 宣告陣列儲存分數
            int[] scores = new int[getFileScoreCount()];
            // 宣告陣列儲存學號
            string[] studentIDs = new string[getFileScoreCount()];
            StreamReader inputFile;
            int index = 0;

            try
            {
                inputFile = File.OpenText("TestScores.txt");

                // 逐行讀取檔案內容
                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    // 讀取一行資料
                    string line = inputFile.ReadLine();
                    
                    // 使用空白字元分割學號和分數
                    string[] parts = line.Split(' ');
                    
                    // 儲存學號
                    studentIDs[index] = parts[0];
                    
                    // 儲存分數
                    scores[index] = int.Parse(parts[1]);
                    
                    index++;
                }
                inputFile.Close();

                // 清空 ListBox
                testScoresListBox.Items.Clear();

                // 顯示學生人數
                testScoresListBox.Items.Add("學生人數： " + scores.Length + " 人");
                
                // 顯示每位學生的學號和分數
                for(int i = 0; i < scores.Length; i++)
                {
                    testScoresListBox.Items.Add(studentIDs[i] + " " + scores[i]);
                }
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show(ex.Message);
            }
            
            // 顯示平均分數（保留一位小數）
            averageScoreLabel.Text = Average(scores).ToString("n1");
            // 顯示最高分數
            highScoreLabel.Text = Highest(scores).ToString();
            // 顯示最低分數
            lowScoreLabel.Text = Lowest(scores).ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
