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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		
        private void button1_Click(object sender, EventArgs e)
        {
			Encoding win1251 = Encoding.GetEncoding(1251);
			int a;
			int n;
			n = int.Parse(numericUpDown1.Text);
			
			//Записываем в файл t.dat вещественные числа из заданного диапазона 
			FileStream f = File.Create("text.dat");
			BinaryWriter fOut = new BinaryWriter(f, win1251);
			string[] arr = textBox1.Text.Split(' ');
			
			for (int i = 0; i < n; i++)
			{
				a = int.Parse(arr[i]);

				if (a<0)
                {
					fOut.Write(a);
				}
					
			}
			fOut.Close();
			//Объекты f и fIn связаны с одним и тем же файлом 
			f = new FileStream("text.dat", FileMode.Open);
			BinaryReader fIn = new BinaryReader(f, win1251);
			long m = f.Length;
			for (long i = 0; i < m; i += 4)
			{

				f.Seek(i, SeekOrigin.Begin);
				int h = fIn.ReadInt32();
				if (h < 0) textBox2.Text += $"{h} ";
			}
			fIn.Close();
			f.Close();
		}

        private void button2_Click(object sender, EventArgs e)
        {
			
		}
    }
}
