using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 投擲硬幣五次的事件處理器
        private void tossButton_Click(object sender, EventArgs e)
        {
            Coin myCoin = new Coin(); // 創建一個 Coin 類的實例

            outputListBox.Items.Clear(); // 清除列表框中的現有項目

            // 投擲硬幣五次並將結果顯示在列表框中
            for (int i = 0; i < 5; i++)
            {
                myCoin.Toss(); // 投擲硬幣
               
                outputListBox.Items.Add(myCoin.GetSideUp()); // 將結果添加到列表框中
            }
        }

        // 結束應用程式的事件處理器
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }
    }
}

