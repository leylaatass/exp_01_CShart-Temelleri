using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k10_HazirFonksiyonlar
{
    public partial class string_fonksiyonlar : Form
    {
        public string_fonksiyonlar()
        {
            InitializeComponent();
        }
       string ornekIfade = "bilge adam";
        private void button1_Click(object sender, EventArgs e)
        {
            
           var sonuc= ornekIfade.CompareTo("adam");
            var sonuc2 = ornekIfade.CompareTo("bilge adam");
            var sonuc3 = ornekIfade.CompareTo("zblge adam"); 
        }

        private void btncontains_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.Contains("adam");
            if (sonuc)
            {
                MessageBox.Show("bu değer örnek ifade içinde geçiyor."); }
            else
            {
                MessageBox.Show("bu değeri içermiyor.");
            }
            var sonuc1 = ornekIfade.Contains("ilge");
            }

        private void btnindexoflastindexof_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.IndexOf('a'); //6.indexte ik a harfiyle  karşılaştı
            var sonuc1 = ornekIfade.LastIndexOf("adam"); // 6.indexte adam kelimesi başladı
            var sonuc2 = ornekIfade.LastIndexOf('a'); //8.indexte en son bulduğu  harfinin indexsini verir.
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.Remove(4);
            var sonuc1 = ornekIfade.Remove(3, 4);
        }

        private void btnreplace_Click(object sender, EventArgs e)
        {
            ornekIfade.Replace('a', 'e');
            var sonuc1 = ornekIfade.Replace("adam", "kadın");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textboxdan alınan ad soyad değerini mail adresi olarak düzenleyiniz.@bilgeadam.com
            //türkçe karakter olmamalı, boşluk olmamalı,hepsi küçük harf olmalı.
            //tolower

            var adSoyad = txtAdSoyad.Text;
            adSoyad
                .ToLower()
                .Replace('ı', 'i')
                .Replace('ç', 'c')
                .Replace('ü', 'u')
                .Replace('ğ', 'g')
                .Replace('ö', 'o')
                .Replace('ş', 's')
                .Replace(' ', '.');
            //var mail = $"{donusturulen} @bilgeadam.com";  // Burayi ben bulunca sana yollaycm
           // MessageBox.Show(mail);

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
           var sonuc= ornekIfade.Insert(0, "çok");
            var sonuc1 = ornekIfade.Insert(5, "cik");
        }

        private void toloperlower_Click(object sender, EventArgs e)
        {
            var sonuc = ornekIfade.ToLower();
            var sonuc1 = ornekIfade.ToUpper();
         
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            var sonuc=ornekIfade.Substring(5); //adam
            var sonuc1 = ornekIfade.Substring(6, 4); //adam


        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
           var ayrilanlar= ornekIfade.Split(' ');
            var metin = "merhaba ,benim adım,nur";
            var ayrilanlar1 = metin.Split(',', ' ');

            // lorem ipsum metninden belli bir kısmı textboxa giriniz ve kaç kelimeden oluşuyor bulunuz. 


        }

        private void btntocahararray_Click(object sender, EventArgs e)
        {
            //foreach(var item in ornekIfade)*/
            char[] harfler = ornekIfade.ToCharArray();
            char[] harfler2 = ornekIfade.ToCharArray(6, 4);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var metin = "  bile adam   ";
            var bosluksuz = metin.Trim(); //trimStart ve TrimEnd

        }
    }
    }

