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
            message = m;
            InitializeComponent();
            DataAccess da = new DataAccess();
            List<Servis> servis = da.GetServis();
            foreach(Servis x in servis)
            {
                ServisIDcb.Items.Add(x.ServisID);
            }
            List<Personel> personel = da.GetPersonel();
            foreach (Personel x in personel)
            {
                PersonelIDcb.Items.Add(x.PersonelID);
            }
            List<Ucak> ucak = da.GetUcak();
            foreach (Ucak x in ucak)
            {
                UcakIDcb.Items.Add(x.UcakID);
            }
            if(message=="Duzenle")
            {
                ServisIDcb.Enabled = false;
                UcakIDcb.Enabled = false;
                KazaTarihi.Enabled = false;
                KazaSebebitb.Enabled = false;
                TamirSonucutb.Enabled = false;
            }
            if (message == "Sil")
            {
                ServisIDcb.Enabled = false;
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
                }
                else if (message == "Duzenle")
                {
                    DataAccess da = new DataAccess();
                    da.UpdateTamir(ServisIDcb.Text, KazaTarihi.Value, KazaSebebitb.Text, TamirSonucutb.Text);
                }
                else if (message == "Sil")
                {
                    DataAccess da = new DataAccess();
                    da.DeleteTamir(ServisIDcb.Text);
                }
            }
        }

        private void ServisIDcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (message == "Duzenle")
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
