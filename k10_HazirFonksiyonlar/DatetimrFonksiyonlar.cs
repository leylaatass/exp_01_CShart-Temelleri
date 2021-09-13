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
    public partial class DatetimrFonksiyonlar : Form
    {
        public DatetimrFonksiyonlar()
        {
            InitializeComponent();
        }
        DateTime simdikizaman = DateTime.Now;
        private void button1_Click(object sender, EventArgs e)
        {
           
            lblsonuc.Text = simdikizaman.ToString();
        }

        private void btnuzunzaman_Click(object sender, EventArgs e)
        {
            lblsonuc.Text = simdikizaman.ToLongDateString();
            MessageBox.Show(simdikizaman.ToLongTimeString());
        }

        private void btnkısazaman_Click(object sender, EventArgs e)
        {
            lblsonuc.Text = simdikizaman.ToShortDateString();
            MessageBox.Show(simdikizaman.ToShortTimeString());
        }

        private void btngun_Click(object sender, EventArgs e)
        {
            lblsonuc.Text = simdikizaman.Day.ToString();
        }

        private void bynay_Click(object sender, EventArgs e)
        {
            lblsonuc.Text = simdikizaman.Month.ToString();
        }

        private void btnyıl_Click(object sender, EventArgs e)
        {
            lblsonuc.Text = simdikizaman.Year.ToString();
        }

        private void btnzamanekle_Click(object sender, EventArgs e)
        {
            simdikizaman.AddDays(35);
            simdikizaman.AddMonths(4);
            simdikizaman.AddYears(45);
        }

        private void btnyaşhesaplatma_Click(object sender, EventArgs e)
        {
            DateTime dogumTarihi = new DateTime(1994, 3, 18);
            var fark = simdikizaman - dogumTarihi;
            var yas=fark.Days /365;
            lblsonuc.Text = yas.ToString();
        }

        private void btnparse_Click(object sender, EventArgs e)
        {
          var tarih1=  DateTime.Parse("2021-05-06");
          var tarih2 = DateTime.Parse("2021/13/05");  //rıntime hatası gönderir çeviremezse

            DateTime cevirilenTarihi;
            var cevirebildinMi = DateTime.TryParse("2021/13/05", out cevirilenTarihi);

            //d: day
            //M: month
            //y:year
            //m: minute
            //H: hour
            //s: second
        }
    }
    }

