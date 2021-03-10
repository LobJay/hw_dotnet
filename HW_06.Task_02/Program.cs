using System;

namespace HW_06.Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] RandomArray = new int[3];
            Random rnd = new Random();
            for (int i = 0; i < RandomArray.Length; i++)
                RandomArray[i] = rnd.Next(100);

            Console.WriteLine("Array of random numbers");
            ArrayWriteLine(RandomArray);

            int[] UserArray = new int[3];
            Console.WriteLine("Input 3 numbers for your array");
            for (int i = 0; i < UserArray.Length; i++)
                UserArray[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Array of your numbers");
            ArrayWriteLine(UserArray);
            Console.WriteLine("Input new number for your array");
            int NewNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the position of this number from your array(0-2)");
            int PosNum = int.Parse(Console.ReadLine());
            for (int i = UserArray.Length - 1; i > 0; i--)
            {
                if (i > PosNum)
                {
                    UserArray[i] = UserArray[i - 1];
                }
                if (i == PosNum)
                {
                    UserArray[i] = NewNum;
                }
            }
            Console.WriteLine("New array of your numbers");
            ArrayWriteLine(UserArray);

            int[] SumArray = new int[3];
            for (int i = 0; i < SumArray.Length; i++)
                SumArray[i] = RandomArray[i] + UserArray[i];

            Console.WriteLine("Array of sum your numbers and random numbers");
            ArrayWriteLine(SumArray);
        }
        static void ArrayWriteLine(int[] arr)
        {
            foreach (int s in arr)
                Console.WriteLine(s);
        }
    }
}
