using System;

namespace HW05.Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int letters = 0;
            Console.WriteLine("Input the word");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; ++i)
            {
                if (word[i] == 'A' || word[i] == 'a' || word[i] == 'А' || word[i] == 'а')
                {
                    letters++;
                }                    
            }               
            Console.WriteLine("Number of letters A in word" + letters);
        }
    }
}
