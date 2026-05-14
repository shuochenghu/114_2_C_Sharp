using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主進入點
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用視覺樣式
            Application.EnableVisualStyles();
            // 設定相容的文字呈現方式
            Application.SetCompatibleTextRenderingDefault(false);
            // 執行主表單
            Application.Run(new Form1());
        }
    }
}
