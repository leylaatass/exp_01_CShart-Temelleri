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
    public partial class whileDongusu : Form
    {
        public whileDongusu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1 'den 100'e kadar olan sayıları while kullanarak listeye yazdırınız.

            int i = 1;
            while (i<=100)
            {
                lstsonuc.Items.Add(i);
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listboxa rastgele ürettiğimiz 10 tane sayıyı ekleyelm. Ancak listede olan bir sayı tekrardan eklenmesin.

            Random rnd = new Random();
            for (int i = 1; i < 10; i++)
            {
                var rastgeleSayi = rnd.Next(1, 5);
                if (lstsonuc.Items.Contains(rastgeleSayi)==false)
                {
                    lstsonuc.Items.Add(rastgeleSayi);
                }
            }
            //listboxun içinde kesin olarak 10 tane rastgele sayı olmasını istiyoruz.
            var listedekielemanSayisi = lstsonuc.Items.Count;
            while (listedekielemanSayisi <=10)
            {
                var rastgeleSayi = rnd.Next(1, 11);
                if (!lstsonuc.Items.Contains(rastgeleSayi))
                {
                    lstsonuc.Items.Add(rastgeleSayi);
                }
            }
        }
    }
}
