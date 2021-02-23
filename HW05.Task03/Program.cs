using System;

namespace HW05.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.TimeOfDay);
            Greeting GObject = new Greeting();
            GObject.Great();
        }
    }


    class Greeting
    {
        public void Great()
        {
            TimeSpan DateNow = DateTime.Now.TimeOfDay;
            int hoursNow = DateNow.Hours;

            switch (hoursNow)
            {
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Good morning, guys!");
                    break;
                case 12:
                case 13:
                case 14:
                    Console.WriteLine("Good day, guys!");
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                    Console.WriteLine("Good evening, guys!");
                    break;
                default:
                    Console.WriteLine("Good night, guys!");
                    break;
            }

            //if (hoursNow >= 9 && hoursNow <= 12)
            //{
            //    Console.WriteLine("Good morning, guys!");
            //}
            //else if (hoursNow >= 13 && hoursNow <= 15)
            //{
            //    Console.WriteLine("Good day, guys!");
            //}
            //else if (hoursNow >= 16 && hoursNow <= 22)
            //{
            //    Console.WriteLine("Good evening, guys!");
            //}
            //else
            //{
            //    Console.WriteLine("Good night, guys!");
            //}
        }

    }

}
