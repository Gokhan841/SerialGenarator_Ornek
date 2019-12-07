using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_Genarator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int i, j;
        string Serial = "ABCÇDEFGHIİJKLMNOÖPRSŞTUÜVYZ0123456789";
        string harfler = "ABCÇDEFGHIİJKLMNOÖPRSŞTUÜVYZ";

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int karaktersayisi = Convert.ToInt32(textBox1.Text);
            int hanesayisi = Convert.ToInt32(textBox2.Text);    
            string[] karakter = new string[hanesayisi];
            string kodsayisal = "";
            for (i = 0; i < hanesayisi; i++)
            {
                karakter[i] = (rnd.Next(0, Convert.ToInt32(Math.Pow(10, karaktersayisi)))).ToString();
                kodsayisal = kodsayisal +"-"+ karakter[i];
            }
            labelsayisal.Text = kodsayisal.Remove(0, 1);
            
            string kodmetinsel = "";
            string kodserial = "";
            string[] a = new string[hanesayisi];
            string[] b = new string[hanesayisi];
            for (i = 0; i < hanesayisi; i++)
            {
                for (int j = 0; j < karaktersayisi; j++)
                {
                    a[i] += harfler[rnd.Next(harfler.Length)];
                    b[i]+= Serial[rnd.Next(Serial.Length)];
                }
                kodmetinsel = kodmetinsel + "-" + a[i];
                kodserial = kodserial + "-" + b[i];
            }
            labelmetinsel.Text = kodmetinsel.Remove(0, 1);
            labelserial.Text = kodserial.Remove(0, 1);
            
// UYARI= Saysal alanı da metinsel ve serial alanlardaki mantık gibi global alanda 0123456789 diye karakter tanımlayarak yap,
//Çünkü başında 0 olan sayıılar üretiyor ve 0'ı göstermeden sayıyı labele yazdırdığı için hane sayısı eksik çıkıyor.
        }
    }
}
