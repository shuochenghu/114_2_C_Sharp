using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        // 用來儲存 CellPhone 物件的清單
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        // GetPhoneData 方法接受一個 CellPhone 物件作為參數，
        // 並將使用者輸入的資料指派給該物件的屬性。
        private void GetPhoneData(CellPhone phone)
        {
            // 暫存變數，用來儲存價格
            decimal price;

            // 取得手機品牌
            phone.Brand = brandTextBox.Text;

            // 取得手機型號
            phone.Model = modelTextBox.Text;

            // 取得手機價格
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // 顯示錯誤訊息
                MessageBox.Show("價格格式不正確");
            }
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            CellPhone phone = new CellPhone();
            GetPhoneData(phone);
            phoneList.Add(phone);

            phoneListBox.Items.Add($"{phone.Brand} {phone.Model}");

            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            brandTextBox.Focus();

        }

        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = phoneListBox.SelectedIndex;

            MessageBox.Show(phoneList[index].Price.ToString("C"));
            // 當選取手機清單項目改變時，可在此處加入顯示或處理選取項目的程式碼
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
