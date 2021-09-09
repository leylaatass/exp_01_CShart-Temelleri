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
    public partial class matematik_fonksiyonlar : Form
    {
        public matematik_fonksiyonlar()
        {
            InitializeComponent();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            //pi sayısını alalım
           var piSayisi= Math.PI;

            //kullanıcıdan alınan bir yarıçapa göre dairenin alanını hesaplayınız. pi*r*r
            double yaricap = Convert.ToDouble(txtDeger.Text);
                var alan =piSayisi*yaricap*yaricap;
            MessageBox.Show(alan.ToString());
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            //mutlak değer alma

            var mutlakDeger = Math.Abs(-143); //143
            var md1 = Math.Abs(-1.43); //1.43

        }

        private void btnCeiling_Click(object sender, EventArgs e)
        {
            //ceiling en yakın üst tam sayıya yuvarlama yapar.
            
            var tamSayi = Math.Ceiling(1.23m); //decimal değer ile kullanımı
            var tamSayi2 = Math.Ceiling(3.85);
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            //en yakın tam alt sayıya yuvarlama yapar.
            var tamSayi = Math.Floor(1.55);
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            var sayi1 = Math.Round(1.50); //2
            var sayi2 = Math.Round(2.12); //2
            var sayi3 = Math.Round(3.89); //4
            var sayi4 = Math.Round(43.122367, 2); //43.12

        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            var sayi = Math.Truncate(43.4353738); //43
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            // işaretli sayılar için negatifse -1 değeri ,0 ise 0; pozitifler için 1 değeri döner.
            var sayi = Math.Sign(-637);  //-1
            var sayi2 = Math.Sign(0);   //0
            var sayi3 = Math.Sign(357);   //1

        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            //üs almak için kullanılır. 
            var sonuc = Math.Pow(2, 5); //32
            var sonuc1 = Math.Pow(2, -1); //0.5

        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            //karekök alma metodurur.
            var sonuc = Math.Sqrt(25); //5

        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
           var sonuc1= Math.Min(10, 2); //2
            var sonuc2 = Math.Max(50, 313); //313
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // sayıları aldıralım
            var sayi1 = Convert.ToInt32(textBox1.Text);
            var sayi2 = Convert.ToInt32(textBox2.Text);
            var sayi3 = Convert.ToInt32(textBox4.Text);

            var buyuk1 = Math.Max(Math.Max(sayi1, sayi2),sayi3);
            var enBuyuk = Math.Max(textBox2.Text);
            MessageBox.Show(enBuyuk.ToString());
        }
    }
}
