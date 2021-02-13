using System;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the year of your birthday:");
            string bYearConv = Console.ReadLine();
            int bYear = Convert.ToInt32(bYearConv);

            Console.WriteLine("Input the number of month of your birthday:");
            string bMonthConv = Console.ReadLine();
            int bMonth = Convert.ToInt32(bMonthConv);

            Console.WriteLine("Input the current year:");
            string curYearConv = Console.ReadLine();
            int curYear = Convert.ToInt32(curYearConv);

            Console.WriteLine("Input the № of current month:");
            string curMonthConv = Console.ReadLine();
            int curMonth = Int32.Parse(curMonthConv);

            int age = curYear - bYear;
            int month = curMonth - bMonth;

            if (month >= 0)
            {
                Console.WriteLine("Your age is " + age);
            }
            else
            {
                Console.WriteLine("Your age is " + (age - 1));
            }
        }
    }
}
