using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k07_Döngüler
{
    public partial class ForeachDongusu : Form
    {
        public ForeachDongusu()
        {
            InitializeComponent();
            string[] isimler = { "bahar", "leyla", "serdar", "çiğdem" };
            foreach (var isim in isimler)
            {
                MessageBox.Show(isim);
            }
            for (int i = 0; i <isimler.Length; i++)
            {
                var isim = isimler[i];
                MessageBox.Show($"{i}.öğrenci{isim}");
            }
        }
    }
}
