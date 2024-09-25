using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc = 0;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 + sayi2;
            label3.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc = 0;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 - sayi2;
            label3.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc = 0;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 * sayi2;
            label3.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc = 0;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 / sayi2;
            label3.Text = sonuc.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double sayi1,sayi2,sonuc = 0;
            sayi1 = Convert.ToDouble(textBox4.Text);
            sayi2 = Convert.ToDouble(textBox4.Text);
            sonuc= sayi1 * sayi2;
            label4.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc = 0;
            s1 = Convert.ToInt32(textBox3.Text);
            s2 = Convert.ToInt32(textBox5.Text);
            sonuc = (s1 + s2) * 2 - 5;
            label5.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double fiyat, sonuc = 0;
            fiyat  = Convert.ToDouble(textBox6.Text);
            sonuc = fiyat - (fiyat * 10 / 100);
            label9.Text = sonuc.ToString("c");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double fiyat, sonuc = 0;
            fiyat = Convert.ToDouble(textBox6.Text);
            sonuc = fiyat - (fiyat * 25 / 100);
            label9.Text = sonuc.ToString("c");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double fiyat, sonuc = 0;
            fiyat = Convert.ToDouble(textBox6.Text);
            sonuc = fiyat - (fiyat * 50 / 100);
            label9.Text = sonuc.ToString("c");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double fiyat, sonuc = 0;
            fiyat = Convert.ToDouble(textBox6.Text);
            sonuc = fiyat - (fiyat * 75 / 100);
            label9.Text = sonuc.ToString("c");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int uk, kk, sonuc = 0;
            uk = Convert.ToInt32(textBox8.Text);
            kk = Convert.ToInt32(textBox7.Text);
            sonuc = uk * kk;
            label12.Text = "Alanı "+ sonuc.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int uk, kk, sonuc = 0;
            uk = Convert.ToInt32(textBox8.Text);
            kk = Convert.ToInt32(textBox7.Text);
            sonuc = uk+uk+kk+kk;
            label12.Text = "Çevresi " + sonuc.ToString();
        }
    }
}
