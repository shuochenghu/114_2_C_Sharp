using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutiformVariable
{
    public partial class MainForm1 : Form
    {
        private string username = "Chuckhu";

        //public string Username
        //{
        //    get { return username; }
        //}

        public MainForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm1 secondForm = new SecondForm1(ref username);
            secondForm.ShowDialog();
            MessageBox.Show("Welcome back, " + username);
        }
    }
}
