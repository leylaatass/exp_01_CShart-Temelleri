using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k06_KararYapilari
{
    public partial class nothesaplama : Form
    {
        public nothesaplama()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //
        private void button1_Click_1(object sender, EventArgs e)
        {
            var vizeDeger = txtVize.Text;
            var vize = Convert.ToDouble(vizeDeger);

            var finalDeger = txtFinal.Text;
            var final = Convert.ToDouble(vizeDeger);

            var ortalama = (vize * 0.3) + (final * 0.7);

            if (ortalama >= 0 && ortalama < 30)
            {
                MessageBox.Show("FF/KALDI" + $"ortalamasi:" + ortalama);
            }
            else if (ortalama >= 30 && ortalama < 50)
            {
                MessageBox.Show("DD/KALDI" + $"Ortalamasi:" + ortalama);
            }
            else if (ortalama >= 50 && ortalama < 60)
            {
                MessageBox.Show("CC/GECTI" + $"Ortalamasi:" + ortalama);
            }
            else if (ortalama >= 60 && ortalama < 85)
            {
                MessageBox.Show("BA/GECTI" + $"Ortalamasi:" + ortalama);
            }
            else if (ortalama > 85)
            {
                MessageBox.Show("AA/GECTI" + $"Ortalamasi:" + ortalama);
            }
            else if (ortalama > 100)
            {
                MessageBox.Show("Geçerli bir sayı giriniz!");
            }
        }
    }
}
    

