using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        private List<BankAccount> accounts = new List<BankAccount>();
        // private BankAccount account;
        // BankAccount field with a $1000 starting balance 


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private BankAccount searchAccount(string accountNumber)
        {
            // 在 accounts 列表中尋找帳戶號碼與 accountNumber 相符的 BankAccount 物件。
            foreach (BankAccount account in accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    return account; // 找到匹配的帳戶，返回該 BankAccount 物件。
                }
            }
            MessageBox.Show("未找到匹配的帳戶號碼", "搜尋錯誤");
            return null; // 若未找到匹配的帳戶，返回 null。
        }
        private void depositButton_Click(object sender, EventArgs e)
        {
            // 從使用者輸入的 depositTextBox 取得欲存入的金額，並解析為 decimal。
            decimal amount;
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                BankAccount account = searchAccount(depositIdTextBox.Text);
                // 呼叫 BankAccount.Deposit 執行存款。
                if (account == null)
                {
                    return; // 若未找到匹配的帳戶，直接返回，不執行存款。
                }
                account.Deposit(amount);
                // 更新畫面上顯示的餘額（以貨幣格式顯示）。
                balanceLabel.Text = account.AccountNumber + "\n" + account.Name + "\n" + account.Balance.ToString("C");
                depositTextBox.Clear(); // 清空存款輸入框，方便下一次輸入。
            }
            else
            {
                // 若輸入無法解析為 decimal，顯示錯誤訊息。
                MessageBox.Show("請輸入有效的存款金額");
                depositTextBox.Clear(); // 清空存款輸入框，讓使用者重新輸入。
                depositIdTextBox.Clear(); // 清空帳戶號碼輸入框，讓使用者重新輸入。
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            // 從使用者輸入的 withdrawTextBox 取得欲提款的金額，並解析為 decimal。
            decimal amount;
            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                BankAccount account = searchAccount(depositIdTextBox.Text);
                // 呼叫 BankAccount.Deposit 執行存款。
                if (account == null)
                {
                    return; // 若未找到匹配的帳戶，直接返回，不執行存款。
                }
                // 呼叫 BankAccount.Withdraw 執行提款。
                account.Withdraw(amount);
                // 更新畫面上顯示的餘額（以貨幣格式顯示）。
                balanceLabel.Text = account.AccountNumber + "\n" + account.Name  + "\n" + account.Balance.ToString("C");
                withdrawTextBox.Clear(); // 清空提款輸入框，方便下一次輸入。
            }
            else
            {
                // 若輸入無法解析為 decimal，顯示錯誤訊息。
                MessageBox.Show("請輸入有效的提款金額");
                withdrawTextBox.Clear(); // 清空提款輸入框，讓使用者重新輸入。
                depositIdTextBox.Clear(); // 清空帳戶號碼輸入框，讓使用者重新輸入。
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void depositTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(balanceTextBox.Text, out decimal amount))
            {
                string accountNumber = accountIDTextBox.Text;
                string name = nameTextBox.Text;
                BankAccount account = new BankAccount(accountNumber, name, amount);
                accounts.Add(account); // 將新帳戶加入帳戶列表
                balanceLabel.Text = accountNumber + "\n" + name + "\n"+account.Balance.ToString("C");
                
                accountIDTextBox.Clear();
                nameTextBox.Clear();
                balanceTextBox.Clear();
                
                if(accounts.Count == 1)
                {
                    depositGroupBox.Visible = true;
                    groupBox1.Visible = true;
                }
            }
            else
            { 
               MessageBox.Show("請輸入有效的初始餘額","輸入錯誤",MessageBoxButtons.OK);
            }
        }
    }
}
