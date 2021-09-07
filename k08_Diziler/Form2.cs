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
            string[] iller = { "ankara", "eskişehir", "adana", "erzincan", "nevşehir", "trabzon", "niğde" };
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
            int[] sayılar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var sayi in sayılar)
            {
                if (sayi % 2 == 0)
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

                //iller dizisi tanımlayalım içine 5 tane il ekleyelim,sonrasında son elemanı seçip mbox'da gösterelim.

                string[] iller = { "ankara", "istanbul", "eskişehir", "adana", "bursa" };
                var soneleman = iller[4];
                var sonEleman = iller[iller.Length - 1]; //5-1=4.index son elemanı verir.
            }
        }
        string[] isimler = { "leyla", "batu", "bahar", "eray", "mustafa", "ömer", "serdar", "çiğdem", "mert", "orkun", "yasemin", "rabia", "utku", "kaan", "batuhan" };
        private void btnratgeleekle_Click(object sender, EventArgs e)
        {
            //golabal olarak isimler dizisi oluşturunuz. butona her bastığımızda rastgele bir index oluşturulsun ve bu indexdeki isim lstboxa eklensin.
            //listboxa bir kez eklenen isim bir daha eklenmesin ve dizideki tüm elemanlar listboxa eklendiyse mbox da ekleyecek eleman kalmadı uyarısı verilsin.

            Random rnd = new Random();
            var rastgeleIndex = rnd.Next(0, isimler.Length);
            var rastgeleSecilenEleman = isimler[rastgeleIndex];
            if (!lstsonuc.Items.Contains(rastgeleSecilenEleman))
            {
                lstsonuc.Items.Add(rastgeleSecilenEleman);         
            }
            else
            {
                MessageBox.Show($"BU isim daha önce eklenmşti:{rastgeleSecilenEleman}");
            }
            if (isimler.Length==lstsonuc.Items.Count)
            {
                btnratgeleekle.Enabled = false;
                MessageBox.Show("Dizideki tüm elemanlar listeye eklendi.");
            }





        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            //sayılar dizisi oluşturalım 7 tane sayı eklensin(rastgele sayılar oluşturulsun)
            //butona her bastığımda dizide elemanları listeye eklesin ve eklenen sayıların toplamı formun başlığında gösterelim.

            var rastgeleSayilar = new int[7];
            Random rnd = new Random();  // instance:nesneden kopya almak demektir.
            for (int i = 0; i < 7; i++)
            {
                var rastgeleSayi = rnd.Next(0, 101);
                rastgeleSayilar[i] = rastgeleSayi;
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textboxda yazılan metni alıp sesli harflerinin ve sessiz harflerini ayırarak lbssesli ve lblsessiz de gösterelim.8 harf sesli harfi tanımlayın
            //string :karakterler dizisidir bu nedenle for veya foreach ile herbir harf incelenebilir.

            var girilen = txtmetin.Text;
            char[] sesliharfler = { 'a', 'e', 'ı', 'i', 'ö', 'o', 'u', 'ü' };
           
            foreach (var harf in girilen)
            {
                if (sesliharfler.Contains(harf))
                {
                    lblsesliler.Text += harf.ToString();
                }
                else
                {
                    lblsessizler.Text += harf.ToString();
                }
            }
        }
    }
}
