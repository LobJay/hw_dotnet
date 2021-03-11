using System;

namespace HW_07.Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your poem. Symbol \";\" separate strings");
            string userpoem = Console.ReadLine();
            string poemA = userpoem.Replace('о', 'а');

            PrintPoem(poemA);
        }
        static void PrintPoem(string poem)
        {           
            string[] separate = poem.Split(';');
            foreach (string newpoem in separate)
            {
                Console.WriteLine(newpoem);
            }
        }
    }
}
