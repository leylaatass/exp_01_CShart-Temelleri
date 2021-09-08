using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k_09_ArraySinifi
{
    public partial class PasswordGenerators : Form
    {
        public PasswordGenerators()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //kullanıcıdan kaç karakterli bir şifre oluşturmak istediğini alalım
            //şifrenin içinde hangi tip karakter geçmesini istediğini soralım(büyük harf(0),küçük harf(1),rakam(2),sembol(3)) en az bir seçim yapmak
            //her biri için dizi oluşturalım
            //hangi dizinin seçim yapacağını rastgele seçmesi laazım
            
            var karakterSayisi = Convert.ToInt32(txtKarakterSayısı.Text);
            var büyükHarfler = new char[0];
            var kucukHarfler = new char[0];
            var rakamlar = new char[0];
            var semboller = new char[0];

            for (char i= 'A'; i<='Z' ; i++)
            {
                Array.Resize(ref buyukHarfler, buyukHarfler.Length + 1);
                buyukHarfler[buyukHarfler.Length - 1] = i;
            }

            Random rnd = new Random();
            var sifre = "";
            while(lstSifreler.length<karakterSayisi)
            var hangiDizidenSecimYapilsin = rnd.Next(0, 4);

            switch (hangiDizidenSecimYapilsin)
            {
               case 0;
                    var rastgeleIndex = rnd.Next(0, buyukHarfler.Length);
                    var secilenHarf = buyukHarfler[rastgeleIndex];
                    lstSifreler+=

            {

            }
            }
        }
    }

}
