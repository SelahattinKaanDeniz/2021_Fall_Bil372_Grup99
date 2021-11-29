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
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();
            List<Personel> personel = da.GetPersonel();
            foreach(Personel x in personel)
            {
                if (x.PersonelTipi == "Kullanici") 
                PersonelIDcb.Items.Add(x.PersonelID);
            }
            KullaniciTipicb.Items.Add("Admin");
            KullaniciTipicb.Items.Add("Servis");
            KullaniciTipicb.Items.Add("Sefer");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Onayla_Click(object sender, EventArgs e)
        {
            if (KullaniciAditb.Text != String.Empty)
            {
                DataAccess da = new DataAccess();
                da.InsertKullanici(KullaniciAditb.Text, Sifretb.Text, KullaniciTipicb.Text, PersonelIDcb.Text);
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void KullaniciEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
