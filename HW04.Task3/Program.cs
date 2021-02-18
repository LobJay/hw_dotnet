using System;

namespace HW04.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();
        }
        static void Sum()
        {
            int number1;
            Console.WriteLine("Input first number:");
            string input1 = Console.ReadLine();

            bool result1 = int.TryParse(input1, out number1);
            if (result1 == false)
            {
                while (result1 == false)
                {
                    Console.WriteLine("That's not a number");
                    Console.WriteLine("Input first number:");
                    result1 = int.TryParse(Console.ReadLine(), out number1);
                }
            }

            int number2;
            Console.WriteLine("Input second number:");
            string input2 = Console.ReadLine();

            bool result2 = int.TryParse(input2, out number2);
            if (result2 == false)
            {
                while (result2 == false)
                {
                    Console.WriteLine("That's not a number");
                    Console.WriteLine("Input second number:");
                    result2 = int.TryParse(Console.ReadLine(), out number2);
                }
            }

            int sum;
            Console.WriteLine("Input the correct answer");
            string input3 = Console.ReadLine();
            bool result3 = int.TryParse(input3, out sum);
            if (sum == number1 + number2)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                if(sum > number1 + number2)
                {
                    Console.WriteLine("Incorrect. Correct answer is less");
                }
                else
                {
                    Console.WriteLine("Incorrect. Correct answer is bigger");
                }
            }


        }
    }
}
