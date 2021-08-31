using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k05_HataYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            //dışarıdan alınan sayıya ulaşmam lazım
            var girilenSayi=txtSayı.Text;
            //convert edilmesi gerekiyor
            var sayi = Convert.ToInt32(girilenSayi);
            //karesini alınız.
            var karesi = sayi * sayi;
            //kullanıcıya göster
            lblSonuç.Text = karesi.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblSonuç_Click(object sender, EventArgs e)
        {

        }
    }
}
