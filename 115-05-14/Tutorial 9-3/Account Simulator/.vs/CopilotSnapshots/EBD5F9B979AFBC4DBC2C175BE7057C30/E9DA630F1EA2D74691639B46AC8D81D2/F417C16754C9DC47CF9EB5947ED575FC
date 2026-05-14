using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    /// <summary>
    /// 銀行帳戶類別：負責管理帳戶的餘額與交易操作。
    /// </summary>
    class BankAccount
    {
        /// <summary>
        /// 帳戶餘額（私有欄位）。
        /// </summary>
        private decimal balance;

        /// <summary>
        /// 建構子：初始化帳戶並設定初始餘額。
        /// </summary>
        /// <param name="initialBalance">初始餘額金額。</param>
        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        /// <summary>
        /// 獲取目前帳戶餘額的屬性。
        /// </summary>
        public decimal Balance
        {
            get { return balance; }
        }

        /// <summary>
        /// 存款方法：將指定金額加入帳戶餘額。
        /// 若金額為負數或零，則顯示警告訊息。
        /// </summary>
        /// <param name="amount">要存入的金額。</param>
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                MessageBox.Show("存款金額必須為正數。");
            }
        }

        /// <summary>
        /// 提款方法：從帳戶餘額中減去指定金額。
        /// 僅在金額為正且不超過目前餘額時才執行提款操作。
        /// 若提款失敗（金額無效或餘額不足），則顯示相應警告訊息。
        /// </summary>
        /// <param name="amount">要提取的金額。</param>
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
            else if (amount <= 0)
            {
                MessageBox.Show("提款金額必須為正數。");
            }
            else
            {
                MessageBox.Show("提款金額不能超過帳戶餘額。");
            }
        }
    }
}
