using System;

namespace HomeworkA {
    internal class Program {
        public static void Main(string[] args) {
//            【C# 家庭作業 -- A. 資料交換程式】
//            int x = 100;
//            int y = 200;
//            請寫一段程式，交換兩個變數的內容。
            int x = 100;
            int y = 200;

            Console.WriteLine("原始資料：");
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);

            int temp;
            temp = x;
            x = y;
            y = temp;

            Console.WriteLine("-----");
            Console.WriteLine("交換後：");
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);
        }
    }
}