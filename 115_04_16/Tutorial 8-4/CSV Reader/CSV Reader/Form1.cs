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

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                
                using (inputFile = File.OpenText("Grades.csv"))
                {
                    string line;
                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine();
                        string[] fields = line.Split(',');
                        if (fields.Length >= 2)
                        {
                            double score1, score2;
                            if (double.TryParse(fields[0], out score1) && double.TryParse(fields[1], out score2))
                            {
                                double average = (score1 + score2) / 2.0;
                                averagesListBox.Items.Add(average.ToString("F2"));
                            }
                            else
                            {
                                MessageBox.Show("無法解析成績: " + line);
                            }
                        }
                        else
                        {
                            MessageBox.Show("資料格式錯誤: " + line);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("讀取 CSV 檔案時發生錯誤: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
