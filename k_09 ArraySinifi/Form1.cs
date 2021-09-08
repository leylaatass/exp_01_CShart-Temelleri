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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //*Array Sınıfı; dizilerle ilgili bazı işlemleri(kopyalama,yeniden boyutlanadırma,sıralama vb)yapmamıza yardımcı olan metotları içerir.

        //Bu sınıftaki tüm öğrencilerin iimlerini bir dizi olarak tanımlayınız ve sonrasında onlineKatılımcılar ve fizikselKatılımcılar isimli iki dizi yaparak buraya kopyalayınız.

        string[] isimler = { "ömer", "leyla", "batuhan", "çiğdem", "bahar", "serdar", "orkun", "batuhan", "anıl", "mustafa", "utku", "yasemin", "eray", "kaan", "mert" };

        private void btnCopy_Click(object sender, EventArgs e)
        {
            
            string[] fizikselKatilimcilar = new string[9];

            Array.Copy(isimler, fizikselKatilimcilar, 9);

            var onlineKatilimcilar = new string[6];
            Array.Copy(isimler, 9, onlineKatilimcilar, 0, 6);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(isimler, 2, 3);
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //IndexOf()

          var bulunanIndex = Array.IndexOf(isimler, "batuhan");
            if (bulunanIndex !=-1)

            {
                MessageBox.Show($"aradığınız isim{bulunanIndex}.indexte bulundu.");
            }
            else
            {
                MessageBox.Show("Dizi içinde aradığınız eleman bulunmuyor!");
            }
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
          var bulunanIndex=  Array.LastIndexOf(isimler, "batuhan");
            if (bulunanIndex !=-1)
            {
                MessageBox.Show("Dizi içinde bu eleman bulunmuyor.");
            }

        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            Array.Reverse(isimler);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Array.Sort(isimler);
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            Array.Resize(ref isimler, 20);
        }
    }
}
