using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
       // BankAccount 欄位，初始餘額為 $1000
       // private BankAccount account = new BankAccount("123456", "John Doe", 1000);
       private List<BankAccount> accounts = new List<BankAccount>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 顯示起始餘額
        }

        private BankAccount searchAccount(string accountNumber)
        {
            foreach (BankAccount account in accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    return account;
                }
            }
            MessageBox.Show("該帳號客戶不存在");
            return null;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(depositAmounttextBox.Text, out amount))
            {
                BankAccount account = searchAccount(depositAccountTextBox.Text);
                if (account == null)
                {
                    return; // 如果帳戶不存在，則退出方法
                }
                account.Deposit(amount);
                balanceLabel.Text = account.AccountNumber + "\n"
                                    + account.Name + "\n"
                                    + account.Balance.ToString("C");
                depositAmounttextBox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid deposit amount. Please enter a valid number.");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(withdrawAmountTextBox.Text, out amount))
            {
                BankAccount account = searchAccount(withdrawAccountTextBox.Text);
                if (account == null)
                {
                    return; // 如果帳戶不存在，則退出方法
                }
                account.Withdraw(amount);
                balanceLabel.Text = account.AccountNumber + "\n"
                                    + account.Name + "\n"
                                    + account.Balance.ToString("C");
                withdrawAmountTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid withdrawal amount. Please enter a valid number.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void accountNumbertextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(balancetextBox.Text, out  amount))
            {
               string accountNumber = accountNumbertextBox.Text;
               string name = nametextBox.Text;
               BankAccount account = new BankAccount(accountNumber, name, amount);
               accounts.Add(account); // 將新帳戶加入列表
                balanceLabel.Text = account.AccountNumber + "\n"
                                    + name + "\n"
                                    + account.Balance.ToString("C");
                balancetextBox.Clear();
                nametextBox.Clear();
                accountNumbertextBox.Clear();
                if (accounts.Count == 1)
                {
                    depositGroupBox.Visible = true;
                    withdrawGroupBox.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid initial balance. Please enter a valid number.");
            }
        }
    }
}