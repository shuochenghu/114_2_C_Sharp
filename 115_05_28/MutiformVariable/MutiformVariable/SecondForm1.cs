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
    public partial class SecondForm1 : Form
    {
        private MainForm1 mainForm;
        public SecondForm1(MainForm1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void SecondForm1_Load(object sender, EventArgs e)
        {
            label1.Text = mainForm.Username;
        }
    }
}
