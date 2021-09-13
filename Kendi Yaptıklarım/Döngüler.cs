using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kendi_Yaptıklarım
{
    public partial class Döngüler : Form
    {
        public Döngüler()
        {
            InitializeComponent();
            //Swich-Case Dögüler
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Bir mevsim giriniz");
            string mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "kış": Console.WriteLine("Aralık,Ocak,Şubat"); break;
                case "ilkbahar": Console.WriteLine("Mart,Nisan,Mayıs"); break;
                case "sonbahar": Console.WriteLine("Eylül,Ekim,Kasım"); break;
                case "yaz": Console.WriteLine("Haziran,Temmuz,Ağustos"); break;

                default: Console.WriteLine("Böyle bir mevsim yok"); break;
            }
            Console.ReadLine();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            var vizeNotu = txtvize.Text;
            var vize = Convert.ToDouble(vizeNotu);

            var finalNotu = txtfinal.Text;
            var final = Convert.ToDouble(finalNotu);

            var ortalama = vize * 0.30 + final * 0.70;

            if (ortalama >= 0 && ortalama < 30)
            {
                MessageBox.Show("FF/kaldı" + $"ortalamasi:" + ortalama);
            }
            else if (ortalama >= 30 && ortalama < 50)
            {
                MessageBox.Show("DD/kaldı" + $"ortalamasi:+ortalama");
            }
            else if (ortalama >= 50 && ortalama < 60)
            {
                MessageBox.Show("CC/kaldı" + $"ortalamasi:+ortalama");
            }
            else if (ortalama >= 60 && ortalama < 85)
            {
                MessageBox.Show("BA/geçti" + $"oratamasi:+ortalama");
            }
            else if (ortalama > 85)
            {
                MessageBox.Show("AA/geçti" + $"ortalamasi:ortalama");
            }
            else
            {
                MessageBox.Show("geçerli not giriniz");
            }


        }
    }
}
    
