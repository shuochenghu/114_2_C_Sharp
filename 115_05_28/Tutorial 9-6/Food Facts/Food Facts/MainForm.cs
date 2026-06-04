using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Facts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // 建立 NutritionForm 類別的實例。
            NutritionForm nutriForm = new NutritionForm();

            // 找出被選取的單選按鈕。
            if (bananaRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = "1 根香蕉";
                nutriForm.caloriesLabel.Text = "100";
                nutriForm.fatLabel.Text = "0.4";
                nutriForm.carbLabel.Text = "27";
            }
            else if (popcornRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = "1 杯空氣爆米花";
                nutriForm.caloriesLabel.Text = "31";
                nutriForm.fatLabel.Text = "0.4";
                nutriForm.carbLabel.Text = "6";
            }
            else if (muffinRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = "1 個大藍莓鬆餅";
                nutriForm.caloriesLabel.Text = "385";
                nutriForm.fatLabel.Text = "9";
                nutriForm.carbLabel.Text = "67";
            }

            // 顯示 NutritionForm。
            nutriForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
