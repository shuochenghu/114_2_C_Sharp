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
    struct Student
    {
        public string Class;
        public string Id;
        public string Name;
        public int[] scores;
    }

    public partial class Form1 : Form
    {
        
        private List<Student> gradeBook = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                gradeBook.Clear();
                averagesListBox.Items.Clear();
                StreamReader inputFile;
                
                using (inputFile = new StreamReader("Grades.csv", Encoding.UTF8))
                {
                    string line;
                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine();
                        string[] fields = line.Split(',');
                        // Expected format: 班級,學號,姓名,score1,score2,score3,score4,score5
                        if (fields.Length == 8)
                        {
                            string className = fields[0];
                            string studentId = fields[1];
                            string studentName = fields[2];
                            
                            int[] scores = new int[5];
                            bool validScores = true;
                            
                            // Parse scores from fields[3] to fields[7]
                            for (int i = 0; i < 5; i++)
                            {
                                if (int.TryParse(fields[i + 3], out int score))
                                {
                                    scores[i] = score;
                                }
                                else
                                {
                                    validScores = false;
                                    break;
                                }
                            }
                            
                            if (validScores)
                            {
                                Student student = new Student();
                                student.Class = className;
                                student.Id = studentId;
                                student.Name = studentName;
                                student.scores = scores;
                                
                                gradeBook.Add(student);
                                
                                int total = student.scores.Sum();
                                double average = (double)total / 5;
                                string output = $"{className} {studentId} {studentName} {average.ToString("F2")}";
                                averagesListBox.Items.Add(output);
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
