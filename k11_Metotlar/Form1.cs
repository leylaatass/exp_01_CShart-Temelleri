using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k11_Metotlar
{
    public partial class Form1 : Form
    {
        #region Metotlar
        private void AdSoyadYazdir()
        {
            MessageBox.Show("Rabia Nur Öztürk");

        }

        private void AdSoyadYazdir(string adSoyad)
        {
            MessageBox.Show(adSoyad);

        }
        private void AdSoyadYazdir(string ad, string soyad)
        {
            MessageBox.Show($"{ad} {soyad}");
        }
        #endregion
        public Form1()
        {
            InitializeComponent();

            AdSoyadYazdir();
            AdSoyadYazdir("Leyla Taş");
            AdSoyadYazdir("NUR", "ÖZTÜRK");
        }

        private void btnadsoyadgöster_Click(object sender, EventArgs e)
        {
            AdSoyadYazdir("Leyla Taş");
        }



        private void btngöster_Click(object sender, EventArgs e)
        {    
            //Ad soyad yazdır göster yapalım.
            var ad = txtad.Text;
            var soyad = txtsoyad.Text;

           // AdSoyadYazdir(ad + " " + soyad);
            AdSoyadYazdir(ad, soyad);
        }
        //metot adı tanımlarken uyulacak metotlar:
        //-Pascal case notasyonu ile tanımlama yapılmalıdır.
        //-Emir kipleri ile tanımlıyoruz

        private int topla(string deger1, string deger2, string deger3)
        {
            var sayi1 = Convert.ToInt32(deger1);
            var sayi2 = Convert.ToInt32(deger2);
            var sayi3 = Convert.ToInt32(deger3);

            var toplam = sayi1 + sayi2 + sayi3;
            return toplam;
        }
        catch(Exception ex)
        
           
    }

}   

