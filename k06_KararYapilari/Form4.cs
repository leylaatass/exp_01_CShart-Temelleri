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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //kullanıcıdan alınan ürün bilgisine göre yönlendirecek reyonu gösteren bir uygulama yapınız.
        //bilgisayar,cep telefonu,minibook yazarsa teknoloji reyonuna ilerleyiniz.
        //parfüm,deodorant,şampuan yazarsa kişisel bakım reyonu
        //domates,biber,patlıcan yazarsa sebze reyonu
        //bunlar dışında birşey yazılırsa bu ürün bulunmamaktadır bilgisini gösteren bir uygulama yapınız.
        private void btn4_Click(object sender, EventArgs e)
        {
         
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var urun = txturun.Text;
            if (urun=="Bigisayar"|| urun=="Cep telefonu"||urun=="Mini Book")
                
            {
                MessageBox.Show("teknoloji reyonuna gidiniz");

            }
            else if (urun=="Parfüm"||urun=="Deodorant"||urun=="Şampuan")
            {
                MessageBox.Show("Kişisel Bakım Reyonuna Gidiniz");

            }
            else if (urun=="domates"||urun=="biber"||urun=="patlıcan")

            {
                MessageBox.Show("Sebze Reyonuna Gidiniz");

            }
            else
            {
                MessageBox.Show("Aranılan Ürün Bulunamadı!");
            }
        }
    }
}
