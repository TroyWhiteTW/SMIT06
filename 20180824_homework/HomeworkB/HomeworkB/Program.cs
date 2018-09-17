using System;

namespace HomeworkB {
    internal class Program {
        public static void Main(string[] args) {
//            【C# 家庭作業 -- B. 出貨單流水號格式產生器】
//            出貨單的單號的格式是 yyyymmddXXXX，其中XXXX是長度固定為四碼的流水號，
//            例如: 第三張的出貨單是0003。換句話說，如果數字不足四位數，在數字左邊要補上適當的零以符合單號長度固定四碼的商業規則。
//
//            請研究一下 String 類別的 Format() 函式，並且試著用它來格式化流水號。

            string today = DateTime.Today.ToString("yyyyMMdd");

            int listId = 3;

            Console.WriteLine(today + "{0:D4}", listId);
        }
    }
}