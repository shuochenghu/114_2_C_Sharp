# 吃角子老虎機遊戲 — 專案規格書

> **學習目標**：使用 AI 工具（如 Claude、GitHub Copilot 等）從零開始，依照本規格書完成一個具備完整遊戲功能的 Windows 桌面應用程式。

## 階段總覽

| 階段 | 目標 | 包含功能 |
|------|------|---------|
| <span style="color:#1a73e8; font-weight:bold">PART 1 基礎版</span> | 遊戲可完整運作 | UI、存入金額、旋轉、賠率、統計、結算 |
| <span style="color:#e8710a; font-weight:bold">PART 2 進階版</span> | 提升遊戲體驗 | 旋轉動畫效果、遊戲紀錄儲存與載入 |

> <span style="color:#188038">✅ 建議先完成基礎版並確認遊戲可正常運作，再進行進階版。</span>

---

---

---

<h1 style="color:#1a73e8; border-bottom:3px solid #1a73e8; padding-bottom:6px">PART 1 — 基礎版</h1>

---

<h2 style="color:#1967d2">1. 專案概述</h2>

| 項目 | 內容 |
|------|------|
| 應用類型 | Windows 桌面應用程式（Windows Forms） |
| 開發語言 | C# |
| 框架版本 | .NET Framework 4.0 以上 |
| 目標平台 | x86 / Any CPU |
| 介面語言 | 繁體中文 |

---

<h2 style="color:#1967d2">2. 介面配置</h2>

### 2.1 視窗規格

- 標題：`吃角子老虎機`
- 視窗大小：寬 530px × 高 430px（不可調整大小）
- 字型：`Microsoft JhengHei`（微軟正黑體）、大小 18pt
- 自動縮放：停用（`AutoScaleMode = None`）

### 2.2 版面區塊（由上至下）

```
┌─────────────────────────────────────┐
│  存入金額：$ [___________] [ 存入 ] │  ← 區塊 A：存入列
│  餘額：$0.00        本次獲得：$0.00  │  ← 區塊 B：即時資訊列
│  ┌────┐  ┌────┐  ┌────┐            │
│  │ 🍎 │  │ 🍋 │  │ 🍊 │            │  ← 區塊 C：三個轉輪
│  └────┘  └────┘  └────┘            │
│  下注金額：[ $1  ▼]                 │  ← 區塊 D：下注選單
│  旋轉：0 次  中獎：0 次  勝率：0.0% │  ← 區塊 E：統計列
│        [ 旋轉  ]   [ 離開  ]        │  ← 區塊 F：操作按鈕
└─────────────────────────────────────┘
```

### 2.3 控制項清單

| 控制項名稱 | 類型 | 用途 |
|-----------|------|------|
| `label_depositPrompt` | Label | 顯示「存入金額：$」提示文字 |
| `textBox_deposit` | TextBox | 輸入欲存入的金額（正整數） |
| `button_deposit` | Button | 確認存入，文字為「存入」 |
| `label_balance` | Label | 即時顯示目前餘額 |
| `label_lastWin` | Label | 即時顯示本次旋轉的獲獎金額 |
| `pictureBox1` | PictureBox | 第一個轉輪（左），120×120px |
| `pictureBox2` | PictureBox | 第二個轉輪（中），120×120px |
| `pictureBox3` | PictureBox | 第三個轉輪（右），120×120px |
| `label_betPrompt` | Label | 顯示「下注金額：」提示文字 |
| `comboBox_bet` | ComboBox | 下注金額選單（DropDownList 模式） |
| `label_totalSpins` | Label | 顯示累計旋轉次數 |
| `label_winCount` | Label | 顯示累計中獎次數 |
| `label_winRate` | Label | 顯示累計勝率（百分比） |
| `button1` | Button | 旋轉按鈕，文字為「旋轉」 |
| `button2` | Button | 離開按鈕，文字為「離開」 |
| `imageList1` | ImageList | 儲存 10 種水果圖片 |

---

<h2 style="color:#1967d2">3. 圖片素材</h2>

轉輪使用 10 種水果圖片，以 `ImageList` 元件儲存，索引對應如下：

| 索引 | 檔名 | 水果 |
|------|------|------|
| 0 | Apple.bmp | 蘋果 |
| 1 | Banana.bmp | 香蕉 |
| 2 | Cherries.bmp | 櫻桃 |
| 3 | Grapes.bmp | 葡萄 |
| 4 | Lemon.bmp | 檸檬 |
| 5 | Lime.bmp | 萊姆 |
| 6 | Orange.bmp | 柳丁 |
| 7 | Pear.bmp | 梨子 |
| 8 | Strawberry.bmp | 草莓 |
| 9 | Watermelon.bmp | 西瓜 |

> 每個 `PictureBox` 的 `SizeMode` 設為 `StretchImage`，圖片自動縮放填滿方塊。

---

<h2 style="color:#1967d2">4. 遊戲功能規格</h2>

### 4.1 存入金額

- 玩家在 `textBox_deposit` 輸入金額後，點擊「存入」按鈕
- <span style="color:#c5221f">**驗證規則**：必須為正整數；否則以訊息方塊提示「請輸入有效的存入金額（必須為正整數）」</span>
- 驗證通過後：
  - 將金額加入 `balance`（目前餘額）
  - 將金額加入 `totalDeposited`（累計存入，供結算盈虧用）
  - 清空輸入方塊
  - 更新介面

### 4.2 下注金額

- 透過 `comboBox_bet` 選擇，固定選項為：`$1`、`$5`、`$10`、`$50`
- 預設選取 `$1`
- 當選項變更時，重新判斷「旋轉」按鈕是否可用

### 4.3 旋轉邏輯

按下「旋轉」後依序執行：

1. 從 `balance` 扣除本次下注金額
2. 以亂數決定三個轉輪的圖片索引（`n1`、`n2`、`n3`），並立即顯示在圖片方塊上
3. 呼叫勝負判斷
4. 更新統計數據與介面

### 4.4 勝負判斷與獎金

| 組合 | 條件 | 獎金倍率 |
|------|------|---------|
| <span style="color:#f4b400; font-weight:bold">頭獎</span> | 三個圖案完全相同（`n1 == n2 == n3`） | 下注金額 × **10** |
| <span style="color:#188038; font-weight:bold">普獎</span> | 任意兩個圖案相同 | 下注金額 × **2** |
| <span style="color:#5f6368">未中獎</span> | 三個圖案均不同 | **0** |

- 計算出的獎金加回 `balance`
- `prize > 0` 即計入中獎次數

### 4.5 旋轉按鈕狀態

| 條件 | 按鈕狀態 |
|------|---------|
| 程式剛啟動（`balance = 0`） | <span style="color:#c5221f">停用</span> |
| `balance < 目前下注金額` | <span style="color:#c5221f">停用</span> |
| `balance >= 目前下注金額` | <span style="color:#188038">啟用</span> |

---

<h2 style="color:#1967d2">5. 介面即時更新規格</h2>

### 5.1 UpdateUI()

每次餘額或獎金改變後呼叫，更新以下項目：

- `label_balance.Text` → `"餘額：" + balance.ToString("c")`
- `label_lastWin.Text` → `"本次獲得：" + prize.ToString("c")`
- 依 `balance >= 下注金額` 決定「旋轉」按鈕啟用狀態

### 5.2 UpdateStats()

每次旋轉結束後呼叫，更新以下項目：

- `label_totalSpins.Text` → `"旋轉：N 次"`
- `label_winCount.Text` → `"中獎：N 次"`
- `label_winRate.Text` → `"勝率：XX.X%"`（`winCount / totalSpins * 100`，保留一位小數）
- <span style="color:#c5221f">當 `totalSpins = 0` 時勝率顯示 `0.0%`（避免除以零）</span>

---

<h2 style="color:#1967d2">6. 結算與離開</h2>

按下「離開」按鈕後：

1. 計算 `netGain = balance - totalDeposited`
2. 以訊息方塊顯示：

```
累計存入：$1,000.00
目前餘額：$850.00
虧損：$150.00

旋轉次數：30 次　中獎次數：12 次
```

3. 關閉主表單

---

<h2 style="color:#1967d2">7. 程式狀態變數</h2>

| 變數名稱 | 型別 | 說明 |
|---------|------|------|
| `rand` | `Random` | 亂數產生器 |
| `n1`, `n2`, `n3` | `int` | 三個轉輪圖片索引（0~9） |
| `prize` | `int` | 本次旋轉獎金（初始 0） |
| `balance` | `int` | 目前餘額（初始 0） |
| `totalDeposited` | `int` | 累計存入金額（初始 0） |
| `totalSpins` | `int` | 累計旋轉次數（初始 0） |
| `winCount` | `int` | 累計中獎次數（初始 0） |

---

<h2 style="color:#1967d2">8. 方法職責</h2>

| 方法 | 觸發時機 | 職責 |
|------|---------|------|
| `Form1_Load` | 程式啟動 | 初始化下注選項；顯示初始圖片 |
| `button_deposit_Click` | 點擊「存入」 | 驗證金額、更新餘額 |
| `button1_Click` | 點擊「旋轉」 | 扣款、決定結果、判斷勝負 |
| `button2_Click` | 點擊「離開」 | 顯示結算摘要、關閉視窗 |
| `comboBox_bet_SelectedIndexChanged` | 切換下注金額 | 重新判斷旋轉按鈕是否可用 |
| `GetBetAmount()` | 需要下注金額時 | 解析 ComboBox 選項字串為整數 |
| `getImage()` | 程式啟動 / 每次旋轉 | 亂數決定 n1~n3 並更新圖片方塊 |
| `checkWinner(bet)` | 每次旋轉後 | 判斷獲獎等級、計算獎金、加回餘額 |
| `UpdateUI()` | 餘額 / 獎金改變時 | 更新餘額、獲獎標籤、按鈕狀態 |
| `UpdateStats()` | 每次旋轉結束後 | 更新旋轉次數、中獎次數、勝率標籤 |

---

<h2 style="color:#1967d2">9. 錯誤處理</h2>

| 情境 | 處理方式 |
|------|---------|
| 存入金額為空白或非數字 | <span style="color:#c5221f">顯示訊息方塊提示，不更新餘額</span> |
| 存入金額為 0 或負數 | <span style="color:#c5221f">同上</span> |
| 餘額不足以下注 | <span style="color:#c5221f">停用「旋轉」按鈕（不允許操作）</span> |

---

<h2 style="color:#1967d2">10. 建議實作順序</h2>

1. 建立空白 Windows Forms 專案，設定字型與視窗大小
2. 加入圖片素材，設定 `ImageList` 並確認索引對應
3. 設計表單版面，放置所有控制項並命名
4. 實作 `Form_Load`：初始化下注選項、呼叫 `getImage()`
5. 實作 `getImage()`：亂數決定並立即顯示三個圖片
6. 實作存入金額：`button_deposit_Click` + 輸入驗證
7. 實作 `checkWinner()`：三段賠率判斷
8. 實作旋轉核心：`button1_Click` 串接扣款 → 圖片 → 判斷
9. 實作 `UpdateUI()`：標籤更新 + 按鈕啟用/停用邏輯
10. 實作 `UpdateStats()`：統計三個標籤
11. 完成結算：`button2_Click` 中的盈虧計算與摘要

---

---

---

<h1 style="color:#e8710a; border-bottom:3px solid #e8710a; padding-bottom:6px">PART 2 — 進階版</h1>

> <span style="color:#c5221f; font-weight:bold">⚠️ 前提：PART 1 基礎版已可正常執行後，再加入以下兩項功能。</span>

---

<h2 style="color:#d56e0c">A. 進階功能一：旋轉動畫</h2>

### A.1 功能說明

按下「旋轉」時，三個圖片方塊先快速隨機切換圖片，模擬轉輪滾動，再依序（左 → 中 → 右）停止並顯示最終結果。

### A.2 機制：Timer 驅動

- 使用 `System.Windows.Forms.Timer`，每 **80ms** 觸發一次
- <span style="color:#1967d2">最終結果（`n1`、`n2`、`n3`）在動畫**開始前**就已用亂數決定，動畫只是視覺效果</span>

### A.3 動畫流程

```
按下「旋轉」
  │
  ├─ 預先決定 n1, n2, n3（亂數）
  ├─ 重置 spinTick = 0，三個 Stopped 旗標設為 false
  └─ spinTimer.Start()
        │
        ├─ 每次 Tick：尚未停止的轉輪顯示隨機圖片
        │
        ├─ Tick 第 10 次（~800ms）
        │     第一個轉輪停止 → 顯示 n1 的最終圖片
        │
        ├─ Tick 第 17 次（~1360ms）
        │     第二個轉輪停止 → 顯示 n2 的最終圖片
        │
        └─ Tick 第 24 次（~1920ms）
              第三個轉輪停止 → 顯示 n3 的最終圖片
              spinTimer.Stop()
              執行勝負判斷 → 更新統計 → 更新介面
```

### A.4 新增狀態變數

| 變數名稱 | 型別 | 說明 |
|---------|------|------|
| `spinTimer` | `Timer` | 動畫計時器，Interval = 80ms |
| `spinTick` | `int` | 目前累計 Tick 次數 |
| `lastBet` | `int` | 本次下注金額（動畫結束後 checkWinner 使用） |
| `pb1Stopped` | `bool` | 第一個轉輪是否已停止 |
| `pb2Stopped` | `bool` | 第二個轉輪是否已停止 |
| `pb3Stopped` | `bool` | 第三個轉輪是否已停止 |
| `TICKS_STOP_PB1` | `const int` | 值為 10，第一輪停止門檻 |
| `TICKS_STOP_PB2` | `const int` | 值為 17，第二輪停止門檻 |
| `TICKS_STOP_PB3` | `const int` | 值為 24，第三輪停止門檻 |

### A.5 按鈕保護（動畫期間）

- <span style="color:#c5221f">動畫進行中「旋轉」按鈕必須停用，防止重複觸發</span>
- `UpdateUI()` 需加入判斷：若 `spinTimer.Enabled = true`，不重新啟用「旋轉」按鈕
- `comboBox_bet_SelectedIndexChanged` 同樣須檢查動畫是否進行中

### A.6 基礎版 `getImage()` 的調整

基礎版中 `getImage()` 同時負責「決定亂數」和「顯示圖片」兩件事。
進階版需要將兩件事分離：

- <span style="color:#1967d2">**決定亂數**（`n1`、`n2`、`n3`）</span>：在 `button1_Click` 中執行，動畫開始前完成
- <span style="color:#1967d2">**顯示圖片**</span>：在 `spinTimer_Tick` 中各自在停止時機執行

> <span style="color:#188038">✅ `getImage()` 原本的邏輯仍保留供 `Form_Load` 初始顯示使用。</span>

---

<h2 style="color:#d56e0c">B. 進階功能二：儲存 / 載入遊戲紀錄</h2>

### B.1 功能說明

程式關閉時自動儲存遊戲狀態，下次啟動時自動載入，還原上次的餘額與統計數據。

### B.2 儲存檔案規格

- 檔名：`savegame.txt`
- 路徑：與執行檔（.exe）相同目錄（`Application.StartupPath`）
- 格式：每行一筆，`key=value`

```
balance=500
totalDeposited=1000
totalSpins=30
winCount=12
```

### B.3 儲存時機

| 時機 | 說明 |
|------|------|
| 存入金額後 | 防止意外關閉造成籌碼遺失 |
| 每次旋轉結束後 | 確保每局都有紀錄 |
| `FormClosing` 事件 | 任何關閉方式（含右上角 ×）皆會觸發 |

> <span style="color:#c5221f">⚠️ 需在 `Form1.Designer.cs` 中將 `FormClosing` 事件繫結至 `Form1_FormClosing` 處理常式。</span>

### B.4 載入時機與規則

- 程式啟動時（`Form_Load` 中最先執行 `LoadGame()`）
- 若 `savegame.txt` 不存在：<span style="color:#188038">靜默忽略，所有數值從 0 開始</span>
- 若檔案格式錯誤或讀取失敗：<span style="color:#188038">捕捉例外，重置所有數值為 0（程式不崩潰）</span>

### B.5 載入的欄位

| 欄位 | 說明 |
|------|------|
| `balance` | 還原目前餘額 |
| `totalDeposited` | 還原累計存入金額 |
| `totalSpins` | 還原旋轉次數 |
| `winCount` | 還原中獎次數 |

### B.6 新增方法

| 方法 | 職責 |
|------|------|
| `SaveGame()` | 將四個數值以 `key=value` 格式寫入 `savegame.txt`；寫入失敗時靜默忽略 |
| `LoadGame()` | 逐行解析 `savegame.txt`，還原四個數值；失敗時重置為 0 |
| `Form1_FormClosing` | 表單關閉前呼叫 `SaveGame()` |

### B.7 錯誤處理

| 情境 | 處理方式 |
|------|---------|
| 儲存檔案失敗（如磁碟滿） | <span style="color:#188038">catch 空區塊靜默忽略，遊戲繼續</span> |
| 載入檔案不存在 | <span style="color:#188038">判斷 `File.Exists()` 為 false，直接 return</span> |
| 載入檔案格式損毀 | <span style="color:#188038">catch 例外，重置所有數值為 0</span> |

---

<h2 style="color:#d56e0c">C. 建議實作順序</h2>

**<span style="color:#d56e0c">功能 A — 旋轉動畫：</span>**

1. 新增 `spinTimer`、`spinTick`、三個常數與三個旗標欄位
2. 在 `Form_Load` 中設定 `spinTimer.Interval = 80` 並繫結 `Tick` 事件
3. 修改 `button1_Click`：移除直接呼叫 `getImage()`，改為亂數決定 n1~n3 後啟動 Timer
4. 實作 `spinTimer_Tick`：三段停止邏輯，最後一段呼叫 `checkWinner` 與 `UpdateUI`
5. 修改 `UpdateUI()` 與 `comboBox_bet_SelectedIndexChanged`：加入 `spinTimer.Enabled` 判斷

**<span style="color:#d56e0c">功能 B — 儲存/載入：</span>**

1. 新增 `SAVE_FILE` 靜態常數（`Application.StartupPath` + `"savegame.txt"`）
2. 實作 `SaveGame()`
3. 實作 `LoadGame()`
4. 在 `Form_Load` 最前面呼叫 `LoadGame()`
5. 在 `button_deposit_Click` 末尾呼叫 `SaveGame()`
6. 在旋轉結束後（`spinTimer_Tick` 最後段 / 基礎版的 `button1_Click` 末尾）呼叫 `SaveGame()`
7. 新增 `Form1_FormClosing` 事件處理常式，呼叫 `SaveGame()`
