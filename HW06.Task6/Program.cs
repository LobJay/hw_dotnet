using System;

namespace HW06.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            char direction;
            Console.WriteLine("Please enter the symbol w, a, s or d");
            string input = Console.ReadLine();
            direction = Convert.ToChar(input);

            if (direction == 'w')
            {
                Console.WriteLine("Move up");
                while(direction == 'w')
                {
                    Console.WriteLine("Choose the direction using wasd");
                    input = Console.ReadLine();                    
                }
            }
            if (direction == 's')
            {
                Console.WriteLine("Move down");
                while (direction == 's')
                {
                    Console.WriteLine("Choose the direction using wasd");
                    input = Console.ReadLine();
                }
            }
            if (direction == 'a')
            {
                Console.WriteLine("Move left");
                while (direction == 's')
                {
                    Console.WriteLine("Choose the direction using wasd");
                    input = Console.ReadLine();
                }
            }
            if (direction == 'd')
            {
                Console.WriteLine("Move right");
                while (direction == 'd')
                {
                    Console.WriteLine("Choose the direction using wasd");
                    input = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("your symbol is incorrect!");
            }
        }
    }
}
