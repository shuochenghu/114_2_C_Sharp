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
    public partial class OpenAccountForm : Form
    {
        private List<BankAccount> bankAccounts;
        public OpenAccountForm(List<BankAccount> accounts)
        {
            InitializeComponent();
            bankAccounts = accounts;
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            // 取得用戶輸入的帳號
            string accountNumber = accountNumberTextBox.Text;
            // 取得用戶輸入的姓名
            string name = nameTextBox.Text;
            // 開戶金額變數
            decimal initialAmount;

            // 驗證開戶金額是否為有效的數字
            if (decimal.TryParse(initialAmountTextBox.Text, out initialAmount))
            {
                // 建立新的銀行帳戶物件
                BankAccount newAccount = new BankAccount(accountNumber, name, initialAmount);
                // 將新帳戶加入到帳戶列表中
                bankAccounts.Add(newAccount);
                
                // 在 resultLabel 中顯示開戶成功的詳細資訊
                // 格式：帳戶建立成功！\n帳號：XXX\n姓名：XXX\n開戶金額：XXX
                resultLabel.Text = string.Format(
                    "帳戶建立成功！\n\n帳號：{0}\n姓名：{1}\n開戶金額：{2:C}",
                    accountNumber,
                    name,
                    initialAmount
                );
            }
            else
            {
                // 開戶金額輸入無效時的錯誤提示
                resultLabel.Text = "開戶失敗！\n\n請輸入有效的開戶金額。";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
