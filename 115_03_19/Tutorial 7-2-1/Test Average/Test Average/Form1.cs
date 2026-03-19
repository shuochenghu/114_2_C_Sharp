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
        private double Average(int[] sArray, int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
            {
                total += sArray[i];
            }
            return (double)total / count;
        }

        // Highest 方法接受一個整數陣列作為參數
        // 並返回該陣列中的最高值
        private int Highest(int[] sArray, int count)
        {
           int highScore = sArray[0];
            for (int i = 1; i < count; i++)
            {
                if (sArray[i] > highScore)
                {
                    highScore = sArray[i];
                }
            }
            return highScore;
        }

        // Lowest 方法接受一個整數陣列作為參數
        // 並返回該陣列中的最低值
        private int Lowest(int[] sArray, int count)
        {
           int lowScore = sArray[0];
            for (int i = 1; i < count; i++)
            {
                if (sArray[i] < lowScore)
                {
                    lowScore = sArray[i];
                }
            }
            return lowScore;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 60;
            int[] scores = new int[SIZE];
            StreamReader inputFile;
            int index = 0;

            try
            {
                inputFile = File.OpenText("TestScores.txt");

                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }
                inputFile.Close();

                for (int i = 0; i < index; i++)
                {
                    testScoresListBox.Items.Add(scores[i]);
                }
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show(ex.Message);
            }
            
            //double averageScore = Average(scores);
            averageScoreLabel.Text = Average(scores, index).ToString("n1");
            highScoreLabel.Text = Highest(scores, index).ToString();
            lowScoreLabel.Text = Lowest(scores, index).ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
