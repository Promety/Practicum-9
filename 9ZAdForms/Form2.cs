using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9ZAdForms
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
            string a = fileIn.ReadToEnd(); //считываем из файла весь текст
            fileIn.Close();
            string[] arr = a.Split('\n');
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
            textBox2.Text += $"Самая короткая строка - {arr[indexStr]}" + Environment.NewLine + 
              $"Ее номер - {indexStr +1 }, размер - {minSizeStr-2}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "D:\\user\\Desktop\\Учебная Практика !!!\\3 неделя\\9 задание\\9Zad\\9ZAdForms\\bin\\Debug\\9.2Zad.txt";
            Process.Start(path);
        }
    }
}
