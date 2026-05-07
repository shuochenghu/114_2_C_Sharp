using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Program8_12
{
    // 應用程式進入點類別
    // 負責初始化 Windows Forms 執行環境並啟動主表單
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();                    // 啟用 Windows 視覺樣式（讓控制項外觀與作業系統一致）
            Application.SetCompatibleTextRenderingDefault(false); // 使用 GDI+ 進行文字渲染（非相容模式）
            Application.Run(new Form1());                        // 建立並執行主表單（吃角子老虎機遊戲視窗）
        }
    }
}
