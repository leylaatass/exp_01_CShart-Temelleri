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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//KARAR YAPILARI

        private void button1_Click(object sender, EventArgs e)

        //textboxa girilen değerin tek yada çift olup olmadığını sorgulayalım.
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi % 2 == 0)
            {
                MessageBox.Show("Girilen Sayı Çifttir");
            }
            else
            {
                MessageBox.Show("Girilen Sayı Tektir");
            }





        }

        private void button2_Click(object sender, EventArgs e)
        //klavyeden girilen sayının hem 20d en büyük hemde çift olması durumuna bakalım.

        {
            int sayi = Convert.ToInt32(textBox2.Text);
            if (sayi % 2 == 0 && sayi >= 20)
            {
                MessageBox.Show("Girilen Sayı Koşulu Sağladı");
            }
            else
            {
                MessageBox.Show("Koşula Uygun Sayı Giriniz");





            }
        }

        private void button3_Click(object sender, EventArgs e)
        //sayının çift olup olmadığının kontrolü veya 20’den büyük olup olmama durumunu kontrol edelim.

        {
            int sayi = Convert.ToInt32(textBox3.Text);
            if (sayi % 2 == 0 || sayi >= 20)
            {
                MessageBox.Show("Sayı çift veya 20'den büyük");
            }
            else
            {
                MessageBox.Show("Sayı çift değil veya 20'den küçük");


            }


        }

        private void btnHesapla_Click(object sender, EventArgs e)
        //Klavyeden 3 ders notu girilen öğrencinin, ortalamasına göre Geçti veya Kaldı şeklinde mesaj veren kodları yazalım.Geçme ortalaması 50 ve üstü olsun.
        {
           // sınav1= Convert.ToDouble(sınav1txt.Text);



           // Ürünün birim fiyatı 20 TL olsun. Eğer üründen 10 ve 10’dan az olursa herhangi bir indirim olmasın, toplam fiyat hesaplansın.Eğer üründen 10’dan fazla 20 ve 20’den de az ise toplam tutara % 10 indirim uygulansın. Eğer ürün adedi 21 ila 30 arasında ise(30 dahil) yüzde 20 indirim olsun. Eğer ürün adedi 31’den fazla ise % 30 indirim olsun. İndirim tutarları toplamdan düşsün ve son tutar hesaplansın.


        }

        
        
           private void button4_Click(object sender, EventArgs e)
        // Ürünün birim fiyatı 20 TL olsun. Eğer üründen 10 ve 10’dan az olursa herhangi bir indirim olmasın, toplam fiyat hesaplansın.Eğer üründen 10’dan fazla 20 ve 20’den de az ise toplam tutara % 10 indirim uygulansın. Eğer ürün adedi 21 ila 30 arasında ise(30 dahil) yüzde 20 indirim olsun. Eğer ürün adedi 31’den fazla ise % 30 indirim olsun. İndirim tutarları toplamdan düşsün ve son tutar hesaplansın.
           
        {
         
        }
    }
    
}
       
        

        
    
    

