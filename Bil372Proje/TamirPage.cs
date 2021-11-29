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
    public partial class TamirPage : Form
    {
        String message;
        public TamirPage(String m)
        {
            InitializeComponent();
            message = m;
            DataAccess da = new DataAccess();
            if (m == "Ekle")
            {
                List<Servis> servis = da.GetAtanmamisTamir();
                foreach (Servis x in servis)
                {
                    ServisIDcb.Items.Add(x.ServisID);
                }
            }
            if (m == "Düzenle")
            {
                List<Tamir> genelbakimlist = da.GetTamir();
                foreach (Tamir x in genelbakimlist)
                {
                    ServisIDcb.Items.Add(x.ServisID);
                }
            }
            List<TamirPersoneli> personel = da.GetTamirPersoneli();
            foreach (TamirPersoneli x in personel)
            {
                PersonelIDcb.Items.Add(x.PersonelID);
            }
            List<Ucak> ucak = da.GetUcak();
            foreach (Ucak x in ucak)
            {
                UcakIDcb.Items.Add(x.UcakID);
            }
            if (message=="Düzenle")
            {
                PersonelIDcb.Enabled = false;
                UcakIDcb.Enabled = false;
                KazaTarihi.Enabled = false;
                KazaSebebitb.Enabled = false;
                TamirSonucutb.Enabled = false;
            }
            if (message == "Sil")
            {
                PersonelIDcb.Enabled = false;
                UcakIDcb.Enabled = false;
                KazaTarihi.Enabled = false;
                KazaSebebitb.Enabled = false;
                TamirSonucutb.Enabled = false;
            }
        }

        private void TamirPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ServisIDcb.Text != String.Empty)
            {
                if (message == "Ekle")
                {
                    DataAccess da = new DataAccess();
                    da.InsertTamir(ServisIDcb.Text, UcakIDcb.Text, PersonelIDcb.Text, KazaTarihi.Value, KazaSebebitb.Text, TamirSonucutb.Text);
                    this.Close();
                }
                else if (message == "Düzenle")
                {
                    DataAccess da = new DataAccess();
                    da.UpdateTamir(ServisIDcb.Text, KazaTarihi.Value, KazaSebebitb.Text, TamirSonucutb.Text);
                    this.Close();
                }
                else if (message == "Sil")
                {
                    DataAccess da = new DataAccess();
                    da.DeleteTamir(ServisIDcb.Text);
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void ServisIDcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (message == "Düzenle")
            {
                DataAccess da = new DataAccess();
                List<Tamir> tamir = da.GetTamir();
                foreach (Tamir x in tamir)
                {
                    if (ServisIDcb.Text == x.ServisID)
                    {
                        PersonelIDcb.Text = x.PersonelID;
                        UcakIDcb.Text = x.UcakID;
                        KazaSebebitb.Text = x.KazaSebebi;
                        KazaTarihi.Value = x.KazaTarihi;
                        TamirSonucutb.Text = x.TamirSonucu;
                    }

                }
                KazaTarihi.Enabled = true;
                KazaSebebitb.Enabled = true;
                TamirSonucutb.Enabled = true;
            }
            if (message == "Sil")
            {
                DataAccess da = new DataAccess();
                List<Tamir> tamir = da.GetTamir();
                foreach (Tamir x in tamir)
                {
                    if (ServisIDcb.Text == x.ServisID)
                    {
                        PersonelIDcb.Text = x.PersonelID;
                        UcakIDcb.Text = x.UcakID;
                        KazaSebebitb.Text = x.KazaSebebi;
                        KazaTarihi.Value = x.KazaTarihi;
                        TamirSonucutb.Text = x.TamirSonucu;
                    }
                }
            }
        }
    }
}
