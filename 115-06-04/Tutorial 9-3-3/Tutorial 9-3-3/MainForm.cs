using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_9_3_3
{
    public partial class MainForm : Form
    {
        // 儲存銀行帳戶的列表
        public List<BankAccount> accounts = new List<BankAccount>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openAccountButton_Click(object sender, EventArgs e)
        {
            OpenAccountForm openAccountForm = new OpenAccountForm(accounts);
            openAccountForm.ShowDialog();
            // 更新已開戶用戶數
            userCountLabel.Text = accounts.Count.ToString();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(accounts); 
            depositForm.ShowDialog();
        }
    }
}
