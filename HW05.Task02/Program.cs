using System;

namespace HW05.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            while (true)
            {
                Console.Write("Input number from 1 to 100: ");
                string userInput = Console.ReadLine();
                bool inputIsParseable = int.TryParse(userInput, out number);

                if (inputIsParseable && number <= 100)
                    break;
                else
                    Console.WriteLine("Incorrect number. Try again: ");
            }

            string indent = " ";
            for (int i = 1, lineLimit = number; i <= number; i++, lineLimit--)
            {
                for (int j = 1; j <= lineLimit; j++)
                    Console.Write(" " + i % 10);

                Console.WriteLine();
                Console.Write(indent);
                indent += " ";
            }
        }
    }
}
