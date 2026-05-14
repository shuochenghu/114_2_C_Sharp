using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // GetPhoneData方法接受一個CellPhone物件作為參數
        // 將使用者輸入的資料指派給該物件的屬性
        private void GetPhoneData(CellPhone phone)
        {
            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;
            if (decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("請輸入有效的價格。");
                phone.Price = 0; // 預設價格為0
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            // 建立新的手機物件
            CellPhone myPhone = new CellPhone();

            // 從輸入框取得使用者輸入的資料並指派給物件
            GetPhoneData(myPhone);

            // 在輸出標籤中顯示物件的屬性
            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
