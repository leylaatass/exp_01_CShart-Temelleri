using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace k08_Diziler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnörnek1_Click(object sender, EventArgs e)
        {
            //öncelikle bir dizi tanımlayalım sonrasında elemanalrını hem tek tek hemde tek seferde listeye ekleyelim.
            string[] iller = { "ankara", "eskişehir", "adana", "erzincan", "nevşehir", "trabzon", "niğde"};
            lstsonuc.Items.Add(iller[0]);
            lstsonuc.Items.Add(iller[1]);
            lstsonuc.Items.Add(iller[2]);
            for (int i = 0; i < iller.Length; i++)
            {
                lstsonuc.Items.Add(iller[i]);
            }
            foreach (var il in iller)
            {
                lstsonuc.Items.Add(il);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1 den 10 a kadar dizi oluşturunuz. sonrasında lstçiftlere çift sayıları,lstteklerede tekleri ekleyiniz.
            int[] sayılar = {1,2,3,4,5,6,7,8,9,10 };
            foreach(var sayi in sayılar)
            {
                if (sayi %2==0)
                {
                    //çifttir
                    lstçiftler.Items.Add(sayi);
                }
                else
                {
                    //tektir
                    lsttekler.Items.Add(sayi);
                }
            }
        }

        private void btnörnek3_Click(object sender, EventArgs e)
        {
            //20 elemanlı bir boş dizi oluşturunuz ve sonrasında for döngüsü ile 1- 20 arasındaki sayıları diziye ekleyiniz ve dizideki elemanların hepsini lstsonuç listesine tek seferd ekleyiniz.
            var sayilar = new int[20];
            //sayilar[0] = 1;

            for (int i = 0; i < 20; i++)
            {
                sayilar[i] = i + 1;
            }
            // lstsonuc.Items.AddRange(sayilar);
            foreach (var sayi in sayilar)
            {
                lstsonuc.Items.Add(sayi);
            }
        }
    }
}
