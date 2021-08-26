using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k04_Yasamdongusu
{
    public partial class YasanDongusu : Form
    {
        /*
         scope:{} arasındaki alana denir.
        bir değiikenin ömrü iki scope arasındadır. 
        */
        int globalDegisken = 100;
      
        public YasanDongusu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            globalDegisken += 5;
            txtDeger.Text = globalDegisken.ToString();
        }

        private void textDeger_TextChanged(object sender, EventArgs e)
        {

        }

        private void YasanDongusu_Load(object sender, EventArgs e)
        {

        }
    }
}
