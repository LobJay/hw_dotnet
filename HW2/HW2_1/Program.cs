using System;
using System.IO;

namespace HW2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Прочитать файл по указанному пути
            //Создать массив, в котором будет храниться прочитанная информация
            //Считать информацию из ранее созданного массива
            //Конвертировать информацию
            //Создать картинку

            StreamReader textReader = new StreamReader(@"C:\Temp\image.txt", true);

            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }

            File.WriteAllBytes(@"C:\Temp\image.png", imageBytes);
            textReader.Dispose();
        }
    }
}
