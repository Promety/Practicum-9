using System;
using System.IO;
using System.Text;

namespace _9Zad
{


    namespace MyProgram
    {
        class Program
        {
            static void Main()
            {
                int a;
                Console.Write("n= ");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                    Console.WriteLine("Введите число заново");


                FileStream f = File.Create("text.dat");
                BinaryWriter fOut = new BinaryWriter(f);
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Введите число №{0}: ", (i + 1));
                    while (!int.TryParse(Console.ReadLine(), out a))
                        Console.Write("Введите число заново\n" + "Введите число №{0}:", (i + 1));
                    fOut.Write(a); ;
                }
                fOut.Close();
                //Объекты f и fIn связаны с одним и тем же файлом
                f = new FileStream("text.dat", FileMode.Open);
                BinaryReader fIn = new BinaryReader(f);
                StreamWriter sw = new StreamWriter(File.Open("9Zad.txt", FileMode.Create), Encoding.UTF8);

                long m = f.Length;
                for (long i = 0; i < m; i += 4)
                {
                    f.Seek(i, SeekOrigin.Begin);
                    int h = fIn.ReadInt32();
                    if (h < 0)
                    {
                        Console.Write(h);
                        sw.Write(h + " ");
                    }
                }
                sw.Close();
                fIn.Close();
                f.Close();
            }
        }
    }

}