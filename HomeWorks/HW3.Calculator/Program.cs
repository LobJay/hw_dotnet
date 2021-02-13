using System;

namespace HW3.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            
            //Convert
            Console.WriteLine("Input first number");
            string num1conv = Console.ReadLine();
            Console.WriteLine("Input second number");
            string num2conv = Console.ReadLine();

            int num1 = Convert.ToInt32(num1conv);
            int num2 = Convert.ToInt32(num2conv);

            Console.WriteLine($"{num1} + {num2} = {calc.add(num1, num2)}");
            Console.WriteLine($"{num1} + {num2} = {calc.subtract(num1, num2)}");
            Console.WriteLine($"{num1} + {num2} = {calc.multiply(num1, num2)}");

            //Parse
            Console.WriteLine("Input first number");
            string num1convInParse = Console.ReadLine();
            Console.WriteLine("Input second number");
            string num2convInParse = Console.ReadLine();

            int num1p = Int32.Parse(num1convInParse);
            int num2p = Int32.Parse(num2convInParse);

            Console.WriteLine($"{num1p} + {num2p} = {calc.division(num1p, num2p)}");
            Console.WriteLine($"{num1p} + {num2p} = {calc.remnant(num1p, num2p)}");

            Console.WriteLine("Input the radius of the circle");
            string radConv = Console.ReadLine();

            double rad = Double.Parse(radConv);

            Console.WriteLine($"{calc.area(rad)}");
        }
    }
    class Calculator
    {
        public int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public double division(int num1, int num2)
        {
            return (double)num1 / num2;
        }

        public int remnant(int num1, int num2)
        {
            return num1 % num2;
        }

        public double area(double radius)
        {
            return 3.14 * radius * radius;
        }
    }
}