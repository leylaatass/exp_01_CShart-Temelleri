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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //kullanıcı dışarıdan kaç adet kitap siparişi edeceği bilgisini girsin.Eğer sipariş adedi 20'den küçükse birim fiyat üzerinden satoş yapılsın;
        //20-50 arasında sipariş verişmişse birim fiyat üzerinden %5 indirim yapılsın 
        //50-100 arasında ise %10
        //100-200 arasında ise %20
        //200'den fazla ise %25 indirim yapılarak kullanıcıya ödemesi gereken tutarı gösteren uygulamayı yapınız.birim fiyat=10 tl alınız.
        private void button1_Click(object sender, EventArgs e)
        {
            var sayi = Convert.ToInt32(textBox1.Text);
            var birimfiyat = 10;
            var toplam = sayi * birimfiyat;
            var ilkindirim = toplam * 0.95;
            var ikinciindirim = toplam * 0.90;
            var ücüncüindirim = toplam * 0.85;
            var dördüncüindirim = toplam * 0.75;
            if (sayi<20)
            {
                MessageBox.Show("ödeyeceğiniz miktar" + toplam);

            }
            else if (sayi>=20 && sayi<50)

            {
                MessageBox.Show("ödeyeceğiniz miktar" + ilkindirim);
            }
            else if (sayi>=50 && sayi<100)

            {
                MessageBox.Show("ödeyeceğiniz miktar" + ikinciindirim);

            }
            else if (sayi>=100 && sayi<200)
            {
                MessageBox.Show("ödeyeceğiniz miktar" + ücüncüindirim);
            }
            else
            {
                MessageBox.Show("ödeyeceğiniz miktar" + dördüncüindirim);
            }
        }
       
	

	
       


    }
}
