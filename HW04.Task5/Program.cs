using System;

namespace HW04.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int az = 122;
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine((char)az);
                az--;
            }
        }
    }
}
