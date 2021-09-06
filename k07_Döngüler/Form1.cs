using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k07_Döngüler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //1'den 100'e kadar sayıları listeye ekleyiniz.
            //object: tüm veri tiplerini kapsar.
            for (int i = 1; i <= 100; i++)
            {
                IstSonuc.Items.Add(i);
            }

        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //100'den 1' e kadar olan sayıları listeleyiniz.
            for (int i = 100; i >= 1; i--)
            {
                IstSonuc.Items.Add(1);
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            for (int i = 10; i >= 50; i += 3)
            {
                IstSonuc.Items.Add(i);



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                IstSonuc.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 20; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    IstSonuc.Items.Add(i);
                }
            }



        }



        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            var toplam = 0;
            for (int i = 1; i <= 10; i++)

            {
                toplam = toplam + i;
            }
            MessageBox.Show(toplam.ToString());
        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            var toplam = 0;
            for (int i = 10; i <= 30; i++)
                if (i % 2 == 1)
                {
                    toplam = toplam + i;

                }
            MessageBox.Show(toplam.ToString());
        }

        private void IstSonuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var rastgelesayi = rnd.Next(1, 11);
            MessageBox.Show(rastgelesayi.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i<=10 ; i++)
            {
                IstSonuc.Items.Add($"{i} Tablosu");
                for (int j = 1; j<=10 ; j++)
                {
                    IstSonuc.Items.Add($"{i}*{j}={i * j}");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnbreak_Click(object sender, EventArgs e)
        {
            //Belli bir koşul sağlandığında döngünün çalışmasını durmka için break kullanılır
            //1 ile 30 arasındaki sayıları yazdıralım 9'un katı olan ilk sayıyı bulduğu zaman döngüden çıkılsın.
            for (int i = 1; i <= 30; i++)
            {
                if (i% 4==0)
                {
                    break;
                }
                IstSonuc.Items.Add(i);
            }
            MessageBox.Show("Döngü sonlandı.Mesaj kutusu açıldı");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i % 4 ==0)
                {
                    return;
                }
                IstSonuc.Items.Add(i);
            }
            MessageBox.Show("Dögü sonlandı.Mesaj kutusu açılmayacak ve buradaki mesaj görünmeyececek.");
        }
    }
}


