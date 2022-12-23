using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9ZadForms___
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            int n = int.Parse(numericUpDown1.Text);


            FileStream f = File.Create("text.dat");
            BinaryWriter fOut = new BinaryWriter(f);
            for (int i = 0; i < n; i++)
            {
                textBox1.Text += i + 1;
                int a = int.Parse(textBox1.Text);
                  
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
