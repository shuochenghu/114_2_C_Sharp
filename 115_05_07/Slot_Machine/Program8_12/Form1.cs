using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program8_12
{
    // 吃角子老虎機遊戲主表單
    // 功能：存入籌碼、選擇下注金額、旋轉動畫、判斷獎金、即時統計、儲存/載入紀錄
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 亂數產生器，用於隨機決定轉輪圖片
        Random rand = new Random();

        // n1、n2、n3：三個轉輪最終停止的圖片索引（動畫開始前預先決定）
        int n1, n2, n3;

        // prize        ：本次旋轉獲得的獎金
        // balance      ：玩家目前的餘額
        // totalDeposited：本局累計存入的總金額
        // lastBet      ：本次旋轉的下注金額（保存供動畫結束後的 checkWinner 使用）
        int prize = 0;
        int balance = 0;
        int totalDeposited = 0;
        int lastBet = 0;

        // ── 旋轉統計 ──────────────────────────────────────────────────────
        // totalSpins：累計旋轉次數
        // winCount  ：累計中獎次數（prize > 0 即算中獎）
        int totalSpins = 0;
        int winCount = 0;
        // ─────────────────────────────────────────────────────────────────

        // ── 旋轉動畫 ──────────────────────────────────────────────────────
        private System.Windows.Forms.Timer spinTimer = new System.Windows.Forms.Timer();
        private int spinTick = 0;

        // 各轉輪停止的 Tick 門檻（Timer 間隔 80ms）
        private const int TICKS_STOP_PB1 = 10;  // ~800ms
        private const int TICKS_STOP_PB2 = 17;  // ~1360ms
        private const int TICKS_STOP_PB3 = 24;  // ~1920ms

        private bool pb1Stopped = false;
        private bool pb2Stopped = false;
        private bool pb3Stopped = false;
        // ─────────────────────────────────────────────────────────────────

        // ── 儲存檔案路徑 ──────────────────────────────────────────────────
        // 儲存於執行檔所在目錄，檔名 savegame.txt
        private static readonly string SAVE_FILE =
            Path.Combine(Application.StartupPath, "savegame.txt");
        // ─────────────────────────────────────────────────────────────────

        // 表單載入：初始化計時器與下注選項，載入上次紀錄，顯示初始圖片
        private void Form1_Load(object sender, EventArgs e)
        {
            spinTimer.Interval = 80;
            spinTimer.Tick += new EventHandler(spinTimer_Tick);

            comboBox_bet.Items.AddRange(new object[] { "$1", "$5", "$10", "$50" });
            comboBox_bet.SelectedIndex = 0;

            LoadGame();   // 若存在存檔則載入，還原上次遊戲狀態

            getImage();
            UpdateUI();
            UpdateStats();
        }

        // 表單關閉前：確保最新狀態已儲存（無論使用者如何關閉視窗）
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveGame();
        }

        // ── 存入金額 ──────────────────────────────────────────────────────

        // 「存入」按鈕：驗證金額後加入餘額，並立即儲存
        private void button_deposit_Click(object sender, EventArgs e)
        {
            int amount;
            if (!int.TryParse(textBox_deposit.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("請輸入有效的存入金額（必須為正整數）");
                return;
            }
            balance += amount;
            totalDeposited += amount;
            textBox_deposit.Clear();
            UpdateUI();
            SaveGame();   // 存入後立即儲存，防止意外關閉造成遺失
        }

        // ── 旋轉流程 ──────────────────────────────────────────────────────

        // 「旋轉」按鈕：扣除下注金額、預先決定最終結果，啟動動畫
        private void button1_Click(object sender, EventArgs e)
        {
            lastBet = GetBetAmount();
            balance -= lastBet;

            n1 = rand.Next(imageList1.Images.Count);
            n2 = rand.Next(imageList1.Images.Count);
            n3 = rand.Next(imageList1.Images.Count);

            spinTick = 0;
            pb1Stopped = false;
            pb2Stopped = false;
            pb3Stopped = false;

            button1.Enabled = false;
            UpdateUI();
            spinTimer.Start();
        }

        // 計時器 Tick：每 80ms 切換隨機圖片，三個轉輪依序停止
        private void spinTimer_Tick(object sender, EventArgs e)
        {
            spinTick++;

            if (!pb1Stopped)
                pictureBox1.Image = imageList1.Images[rand.Next(imageList1.Images.Count)];
            if (!pb2Stopped)
                pictureBox2.Image = imageList1.Images[rand.Next(imageList1.Images.Count)];
            if (!pb3Stopped)
                pictureBox3.Image = imageList1.Images[rand.Next(imageList1.Images.Count)];

            if (spinTick == TICKS_STOP_PB1)
            {
                pb1Stopped = true;
                pictureBox1.Image = imageList1.Images[n1];
            }

            if (spinTick == TICKS_STOP_PB2)
            {
                pb2Stopped = true;
                pictureBox2.Image = imageList1.Images[n2];
            }

            if (spinTick == TICKS_STOP_PB3)
            {
                pb3Stopped = true;
                pictureBox3.Image = imageList1.Images[n3];

                spinTimer.Stop();
                checkWinner(lastBet);

                // 更新統計數據
                totalSpins++;
                if (prize > 0) winCount++;

                UpdateUI();
                UpdateStats();
                SaveGame();   // 每次旋轉結束後自動儲存
            }
        }

        // 從 ComboBox 取得目前選擇的下注金額
        private int GetBetAmount()
        {
            return int.Parse(comboBox_bet.SelectedItem.ToString().TrimStart('$'));
        }

        // 隨機更新三個轉輪圖片（僅用於初始顯示）
        private void getImage()
        {
            n1 = rand.Next(imageList1.Images.Count);
            n2 = rand.Next(imageList1.Images.Count);
            n3 = rand.Next(imageList1.Images.Count);
            pictureBox1.Image = imageList1.Images[n1];
            pictureBox2.Image = imageList1.Images[n2];
            pictureBox3.Image = imageList1.Images[n3];
        }

        // 三連頭獎 ×10，雙連普獎 ×2，未中獎 ×0
        private void checkWinner(int bet)
        {
            if (n1 == n2 && n2 == n3)
                prize = bet * 10;
            else if (n1 == n2 || n1 == n3 || n2 == n3)
                prize = bet * 2;
            else
                prize = 0;

            balance += prize;
        }

        // ── 介面更新 ──────────────────────────────────────────────────────

        // 更新餘額、本次獲得，以及旋轉按鈕的啟用狀態
        private void UpdateUI()
        {
            label_balance.Text  = "餘額：" + balance.ToString("c");
            label_lastWin.Text  = "本次獲得：" + prize.ToString("c");

            // 動畫進行中不重新啟用旋轉按鈕
            if (!spinTimer.Enabled)
                button1.Enabled = (balance >= GetBetAmount());
        }

        // 更新旋轉次數、中獎次數、勝率三個統計標籤
        private void UpdateStats()
        {
            double winRate = totalSpins > 0
                ? (double)winCount / totalSpins * 100.0
                : 0.0;

            label_totalSpins.Text = "旋轉：" + totalSpins + " 次";
            label_winCount.Text   = "中獎：" + winCount + " 次";
            label_winRate.Text    = "勝率：" + winRate.ToString("F1") + "%";
        }

        // 下注金額選項變更時重新判斷旋轉按鈕狀態
        private void comboBox_bet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_bet.SelectedItem != null && !spinTimer.Enabled)
                button1.Enabled = (balance >= GetBetAmount());
        }

        // ── 儲存 / 載入 ───────────────────────────────────────────────────

        // 將遊戲狀態以 key=value 格式寫入 savegame.txt
        private void SaveGame()
        {
            try
            {
                File.WriteAllLines(SAVE_FILE, new string[]
                {
                    "balance="       + balance,
                    "totalDeposited=" + totalDeposited,
                    "totalSpins="    + totalSpins,
                    "winCount="      + winCount
                });
            }
            catch { /* 儲存失敗時靜默忽略，不影響遊戲進行 */ }
        }

        // 從 savegame.txt 載入遊戲狀態；檔案不存在或格式錯誤時從頭開始
        private void LoadGame()
        {
            if (!File.Exists(SAVE_FILE)) return;

            try
            {
                foreach (string line in File.ReadAllLines(SAVE_FILE))
                {
                    string[] parts = line.Split('=');
                    if (parts.Length != 2) continue;

                    int value;
                    if (!int.TryParse(parts[1], out value)) continue;

                    switch (parts[0])
                    {
                        case "balance":        balance        = value; break;
                        case "totalDeposited": totalDeposited = value; break;
                        case "totalSpins":     totalSpins     = value; break;
                        case "winCount":       winCount       = value; break;
                    }
                }
            }
            catch
            {
                // 讀取或解析失敗：重置所有數值，從頭開始
                balance = totalDeposited = totalSpins = winCount = 0;
            }
        }

        // ── 離開 ──────────────────────────────────────────────────────────

        // 「離開」按鈕：顯示本局盈虧結算後關閉（FormClosing 會再呼叫 SaveGame）
        private void button2_Click(object sender, EventArgs e)
        {
            int netGain = balance - totalDeposited;
            string resultLabel = netGain >= 0 ? "獲利" : "虧損";
            MessageBox.Show(
                "累計存入：" + totalDeposited.ToString("c") + "\n" +
                "目前餘額：" + balance.ToString("c") + "\n" +
                resultLabel + "：" + Math.Abs(netGain).ToString("c") + "\n\n" +
                "旋轉次數：" + totalSpins + " 次　" +
                "中獎次數：" + winCount + " 次"
            );
            this.Close();
        }
    }
}
