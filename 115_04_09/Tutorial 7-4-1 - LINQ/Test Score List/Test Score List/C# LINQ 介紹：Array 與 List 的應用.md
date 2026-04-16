---
title: C# LINQ 介紹：Array 與 List 的應用

---

# C# LINQ 介紹：Array 與 List 的應用

## 什麼是 LINQ？

**LINQ（Language Integrated Query）** 是 C# 3.0 引入的強大功能，讓開發者能以**統一、簡潔的語法**對各種資料來源進行查詢與操作，包括陣列、集合、資料庫、XML 等。

LINQ 的核心優勢：
- ✅ 語法簡潔，易於閱讀
- ✅ 型別安全（Compile-time checking）
- ✅ 統一查詢介面，適用多種資料來源
- ✅ 支援延遲執行（Deferred Execution）

---

## LINQ 語法風格

LINQ 有兩種等價的語法寫法：

| 風格 | 說明 | 範例 |
|------|------|------|
| **查詢語法（Query Syntax）** | 類似 SQL 的宣告式語法，本課程主要使用 | `from x in list where x > 5 select x` |
| **方法語法（Method Syntax）** | 使用擴充方法與 Lambda 表達式（後續課程介紹） | `list.Where(x => x > 5)` |

> 💡 本文範例以**查詢語法**為主；部分不需 Lambda 的方法（如 `Take`、`Skip`、`Sum` 等）直接呼叫。

---

## 必要命名空間

```csharp
using System;
using System.Collections.Generic;
using System.Linq; // ← LINQ 的核心命名空間
```

---

## 一、LINQ 在 Array（陣列）上的應用

### 1. 基本過濾（where）

```csharp
int[] scores = { 45, 78, 92, 55, 88, 60, 71 };

// 查詢語法：篩選及格分數（>= 60）
var passing = from s in scores
              where s >= 60
              select s;

Console.WriteLine("及格分數：" + string.Join(", ", passing));
// 輸出：及格分數：78, 92, 88, 60, 71
```

---

### 2. 排序（orderby）

```csharp
string[] fruits = { "Banana", "Apple", "Cherry", "Mango", "Grape" };

// 升冪排序
var sorted = from f in fruits
             orderby f
             select f;

// 降冪排序
var sortedDesc = from f in fruits
                 orderby f descending
                 select f;

Console.WriteLine("升冪：" + string.Join(", ", sorted));
// 輸出：升冪：Apple, Banana, Cherry, Grape, Mango

Console.WriteLine("降冪：" + string.Join(", ", sortedDesc));
// 輸出：降冪：Mango, Grape, Cherry, Banana, Apple
```

---

### 3. 轉換（select）

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };

// 每個數字乘以 2
var doubled = from n in numbers
              select n * 2;

// 轉換為字串格式
var formatted = from n in numbers
                select $"No.{n:D2}";

Console.WriteLine(string.Join(", ", doubled));   // 2, 4, 6, 8, 10
Console.WriteLine(string.Join(", ", formatted)); // No.01, No.02, No.03, No.04, No.05
```

---

### 4. 聚合函式（Aggregate Functions）

> 對純值陣列使用聚合函式時，不需要 Lambda，可直接呼叫。

```csharp
int[] data = { 3, 7, 2, 9, 5, 1, 8 };

Console.WriteLine($"總和：{data.Sum()}");        // 35
Console.WriteLine($"平均：{data.Average()}");    // 5
Console.WriteLine($"最大值：{data.Max()}");      // 9
Console.WriteLine($"最小值：{data.Min()}");      // 1
Console.WriteLine($"元素數量：{data.Count()}");  // 7
```

---

### 5. 包含判斷（Contains）

```csharp
int[] grades = { 55, 70, 85, 90, 45 };

bool has90  = grades.Contains(90);   // true
bool has100 = grades.Contains(100);  // false

Console.WriteLine($"有90分：{has90}");
Console.WriteLine($"有100分：{has100}");
```

---

### 6. 取部分元素（Take / Skip）

> `Take` 與 `Skip` 不需 Lambda，可直接呼叫。

```csharp
int[] nums = { 10, 20, 30, 40, 50, 60, 70, 80 };

var top3  = nums.Take(3);          // 前3個：10, 20, 30
var skip3 = nums.Skip(3);          // 跳過3個：40, 50, 60, 70, 80
var page2 = nums.Skip(3).Take(3);  // 分頁（第2頁）：40, 50, 60

Console.WriteLine("前3個：" + string.Join(", ", top3));
Console.WriteLine("分頁：" + string.Join(", ", page2));
```

---

## 二、LINQ 在 List\<T\> 上的應用

### 1. 物件集合的定義

```csharp
public class Student
{
    public string Name       { get; set; }
    public int    Age        { get; set; }
    public double GPA        { get; set; }
    public string Department { get; set; }
}

var students = new List<Student>
{
    new Student { Name = "Alice", Age = 20, GPA = 3.8, Department = "資管" },
    new Student { Name = "Bob",   Age = 22, GPA = 3.2, Department = "資工" },
    new Student { Name = "Carol", Age = 21, GPA = 3.9, Department = "資管" },
    new Student { Name = "David", Age = 23, GPA = 2.8, Department = "資工" },
    new Student { Name = "Eve",   Age = 20, GPA = 3.5, Department = "資管" },
};
```

---

### 2. 過濾（where）

```csharp
// 查詢資管系的學生
var imStudents = from s in students
                 where s.Department == "資管"
                 select s;

foreach (var s in imStudents)
    Console.WriteLine($"{s.Name} - GPA: {s.GPA}");

// 輸出：
// Alice - GPA: 3.8
// Carol - GPA: 3.9
// Eve   - GPA: 3.5
```

---

### 3. 過濾 + 排序組合

```csharp
// 查詢 GPA >= 3.5 的學生，並按 GPA 降冪排列
var topStudents = from s in students
                  where s.GPA >= 3.5
                  orderby s.GPA descending
                  select s;

foreach (var s in topStudents)
    Console.WriteLine($"{s.Name} - GPA: {s.GPA}");

// 輸出：
// Carol - GPA: 3.9
// Alice - GPA: 3.8
// Eve   - GPA: 3.5
```

---

### 4. 多條件排序

```csharp
// 先按科系升冪，相同科系再按 GPA 降冪
var sorted = from s in students
             orderby s.Department, s.GPA descending
             select s;

foreach (var s in sorted)
    Console.WriteLine($"{s.Department} | {s.Name} | {s.GPA}");

// 輸出：
// 資工 | Bob   | 3.2
// 資工 | David | 2.8
// 資管 | Carol | 3.9
// 資管 | Alice | 3.8
// 資管 | Eve   | 3.5
```

---

### 5. 投影（select 特定欄位）

```csharp
// 只取出姓名清單
var names = from s in students
            select s.Name;

Console.WriteLine(string.Join(", ", names));
// 輸出：Alice, Bob, Carol, David, Eve

// 投影為匿名型別（取部分欄位）
var summary = from s in students
              select new { s.Name, s.Department, s.GPA };

foreach (var item in summary)
    Console.WriteLine($"{item.Name}（{item.Department}）：{item.GPA}");
```

---

### 6. 分組（group by）

```csharp
// 依科系分組
var byDept = from s in students
             group s by s.Department;

foreach (var group in byDept)
{
    Console.WriteLine($"\n【{group.Key}】");
    foreach (var s in group)
        Console.WriteLine($"  {s.Name} - GPA: {s.GPA}");
}

// 輸出：
// 【資管】
//   Alice - GPA: 3.8
//   Carol - GPA: 3.9
//   Eve   - GPA: 3.5
// 【資工】
//   Bob   - GPA: 3.2
//   David - GPA: 2.8
```

---

### 7. 分組後統計人數（into）

```csharp
// 各科系人數統計
var deptCount = from s in students
                group s by s.Department into g
                select new { Department = g.Key, Count = g.Count() };

foreach (var item in deptCount)
    Console.WriteLine($"{item.Department}：{item.Count} 人");

// 輸出：
// 資管：3 人
// 資工：2 人
```

---

### 8. 集合操作（Distinct / Union / Intersect / Except）

> 這些方法作用於整個集合，不需要 Lambda。

```csharp
var listA = new List<int> { 1, 2, 3, 4, 5 };
var listB = new List<int> { 3, 4, 5, 6, 7 };

var union     = listA.Union(listB);      // 聯集：1,2,3,4,5,6,7
var intersect = listA.Intersect(listB);  // 交集：3,4,5
var except    = listA.Except(listB);     // 差集（A-B）：1,2

Console.WriteLine("聯集：" + string.Join(", ", union));
Console.WriteLine("交集：" + string.Join(", ", intersect));
Console.WriteLine("差集：" + string.Join(", ", except));

// 去除重複元素
var withDups = new List<int> { 1, 2, 2, 3, 3, 4 };
var distinct = withDups.Distinct();
Console.WriteLine("去重：" + string.Join(", ", distinct)); // 1,2,3,4
```

---

## 三、延遲執行 vs 立即執行

| 操作類型 | 執行時機 | 說明 |
|----------|----------|------|
| `from...where...select`、`orderby`、`group by` | **延遲執行** | 僅建立查詢描述，遍歷時才真正執行 |
| `ToList()`、`ToArray()`、`Count()`、`Sum()`、`Max()` | **立即執行** | 呼叫當下立即執行查詢並取得結果 |

```csharp
// 建立查詢，此時尚未執行
var query = from s in students
            where s.GPA > 3.0
            select s;

// 動態新增一筆資料
students.Add(new Student { Name = "Frank", GPA = 3.6, Department = "資管" });

// 此時才真正執行，Frank 也會被包含進去
var result = query.ToList();

Console.WriteLine("人數：" + result.Count); // 5（含 Frank）
```

> 💡 若希望固定查詢結果、不受後續資料變動影響，請在查詢末尾加上 `.ToList()`。

---

## 四、常用 LINQ 方法速查表

| 方法 / 關鍵字 | 說明 | 是否需要 Lambda |
|---------------|------|-----------------|
| `where` | 過濾符合條件的元素 | 查詢語法不需要 |
| `select` | 投影／轉換每個元素 | 查詢語法不需要 |
| `orderby / descending` | 排序（支援多欄位） | 查詢語法不需要 |
| `group by / into` | 分組 | 查詢語法不需要 |
| `Take(n)` | 取前 n 個 | ❌ 不需要 |
| `Skip(n)` | 跳過前 n 個 | ❌ 不需要 |
| `Contains(value)` | 是否包含指定值 | ❌ 不需要 |
| `Count()` | 元素數量 | ❌ 不需要（無條件版） |
| `Sum() / Max() / Min() / Average()` | 純值聚合計算 | ❌ 不需要（純值版） |
| `Distinct()` | 去除重複元素 | ❌ 不需要 |
| `Union / Intersect / Except` | 集合運算 | ❌ 不需要 |
| `ToList()` | 轉為 `List<T>`（立即執行） | ❌ 不需要 |
| `ToArray()` | 轉為陣列（立即執行） | ❌ 不需要 |

---

## 總結

```
資料來源（Array / List）
        ↓
    LINQ 查詢語法
  ┌──────────────────────────────────┐
  │  from  →  where  →  orderby     │
  │  group by  →  select            │
  └──────────────────────────────────┘
        ↓
  ToList() / ToArray() / 直接遍歷
```

LINQ 讓資料處理邏輯更貼近「**描述要什麼**」而非「**怎麼做**」，大幅提升程式碼的可讀性與維護性。  
掌握查詢語法後，搭配 Lambda 的方法語法將進一步解鎖更多強大用法！