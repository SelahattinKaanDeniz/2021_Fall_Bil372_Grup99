using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil372ProjeGrup99
{
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
            Sifretb.PasswordChar = '*';
        }


        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {
            label3.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (da.MatchKullaniciAdi(KullaniciAditb.Text))
            {
                if (da.MatchSifre(Aescoding.Encrypt(Sifretb.Text)))
                {
                    String tip = da.GetKullaniciTipi(KullaniciAditb.Text);
                    switch (tip)
                    {
                        case "Admin":
                            AdminPage newscreen = new AdminPage();
                            newscreen.ShowDialog();
                            this.Hide();
                            break;
                            
                        case "Servis":
                            ServisYoneticisiPage newscreen1 = new ServisYoneticisiPage();
                            newscreen1.ShowDialog();
                            this.Hide();
                            break;

                        case "Sefer":
                            SeferYoneticisiPage newscreen2 = new SeferYoneticisiPage();
                            newscreen2.ShowDialog();
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    label3.Text = "Kullanici adi veya sifre yanlis girildi.";
                }
            }
            else
            {
                label3.Text = "Kullanici adi veya sifre yanlis girildi.";
            }
        }

        private void Sifretb_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
