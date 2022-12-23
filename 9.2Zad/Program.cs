using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _9._2Zad
{
    class Program
    {
        static void Main()
        {
			StreamReader fileIn = new StreamReader("9.2Zad.txt");
			string text = fileIn.ReadToEnd(); //считываем из файла весь текст
			fileIn.Close();   
            string[] arr = File.ReadAllLines("9.2Zad.txt");
            
            //поиск самой короткой строки
            int minSizeStr = arr[0].Length;
            int indexStr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length < minSizeStr)
                {
                    minSizeStr = arr[i].Length;
                    indexStr = i;
                }  
            }
            Console.WriteLine($"Самая короткая строка - {arr[indexStr]}\n" +
              $"Ее номер - {indexStr +1}, размер - {minSizeStr - 1}");
        }
    }
}
