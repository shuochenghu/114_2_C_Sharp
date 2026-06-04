using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform_Practice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayFormButton_Click(object sender, EventArgs e)
        {
            // 建立 MessageForm 類別的實例（若尚未建立該類別請先新增）。
            MessageForm myMessageForm = new MessageForm();

            // 顯示該表單（可視需求改用 Show 或 ShowDialog）。
            //myMessageForm.ShowDialog();  -> 以模態方式顯示表單，使用者必須先關閉該表單才能返回主表單。
            myMessageForm.Show(); //-> 以非模態方式顯示表單，使用者可以同時操作主表單和新表單。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
