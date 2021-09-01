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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)

        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (kullaniciAdi)
            {
                case "admin":
                    switch (parola)
                    {
                        case "1234":
                            MessageBox.Show("Giriş Başarılı!");
                            break;
                        default:
                            MessageBox.Show("Kullanıcı adınız doğru ancak parolanız yanlış.");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("")

                default:
                    break;
            }
        }
    

