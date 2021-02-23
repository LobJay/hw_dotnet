using System;

namespace HW._05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a positive number: ");
            string userInput = Console.ReadLine();

            int answer = 0;

            if (int.TryParse(userInput, out int userNum))
            {
                for (int i = 1; i <= userNum; i++)
                {
                    answer += i;
                }
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("Incorrect number. Try again:");               
            }
        } 
    }
}
