using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9ZadForms___
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader fileIn = new StreamReader("9.2Zad.txt");
            string text = fileIn.ReadToEnd(); //считываем из файла весь текст
            fileIn.Close();
            string[] arr = File.ReadAllLines("9.2Zad.txt");
            //поиск самой длинной строки
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
            //вывод в консоль
            textBox1.Text +=($"Самая короткая строка - {arr[indexStr]}\n" + Environment.NewLine +
              $"Ее номер - {indexStr + 1}, размер - {minSizeStr - 1}");


        }
        }
    }

    
