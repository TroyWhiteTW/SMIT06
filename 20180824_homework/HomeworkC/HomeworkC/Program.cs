using System;

namespace HomeworkC {
    internal class Program {
        public static void Main(string[] args) {
//            【C# 家庭作業 -- C. 計算特定月份的天數】
//            請用中文描述：如果任給你一個日期，你要如何找出該月有幾天？

            // my answer: 使用 DateTime.DaysInMonth() 來找出該月有幾天，方法內第一個參數給年分，第二的參數給月份，即可得到結果 
            
            const int July = 7;
            const int Feb = 2;

            int daysInJuly = DateTime.DaysInMonth(2001, July);
            Console.WriteLine(daysInJuly);

            // daysInFeb gets 28 because the year 1998 was not a leap year.
            int daysInFeb = DateTime.DaysInMonth(1998, Feb);
            Console.WriteLine(daysInFeb);

            // daysInFebLeap gets 29 because the year 1996 was a leap year.
            int daysInFebLeap = DateTime.DaysInMonth(1996, Feb);
            Console.WriteLine(daysInFebLeap);
        }
    }
}