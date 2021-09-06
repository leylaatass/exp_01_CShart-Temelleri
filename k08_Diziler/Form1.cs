using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k08_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int sayi1 = 10;
            string isim = "bahar";
            bool DogruMu = true;
            decimal para = 1029.32m;
            float not = 50.33f;
            double ortalama = 13.0;

            //Diziler
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7 };
            string[] isimler = new string[] { "bahar", "serdar", "eray" };
            var iller = new string[3];
            iller[0] = "Ankara";
            iller[1] = "İzmir";
            iller[2] = "Eskişehir";
            iller[3] = "istanbul";
        }

    }
}
