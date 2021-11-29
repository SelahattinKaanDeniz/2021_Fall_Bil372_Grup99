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
    public partial class GenelBakimPage : Form
    {
        String message;
        public GenelBakimPage(String m)
        {
            InitializeComponent();
            message = m;
            InitializeComponent();
            DataAccess da = new DataAccess();
            List<Servis> servis = da.GetServis();
            foreach (Servis x in servis)
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
            if (message == "Duzenle")
            {
                PersonelIDcb.Enabled = false;
                UcakIDcb.Enabled = false;
                BakimTurutb.Enabled = false;
            }
            if (message == "Sil")
            {
                PersonelIDcb.Enabled = false;
                UcakIDcb.Enabled = false;
                BakimTurutb.Enabled = false;
            }
        }

        private void GenelBakimPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ServisIDcb.Text != String.Empty)
            {
                if (message == "Ekle")
                {
                    DataAccess da = new DataAccess();
                    da.InsertGenelBakim(ServisIDcb.Text, UcakIDcb.Text, PersonelIDcb.Text, BakimTurutb.Text);
                }
                else if (message == "Duzenle")
                {
                    DataAccess da = new DataAccess();
                    da.UpdateGenelBakim(ServisIDcb.Text, BakimTurutb.Text);
                }
                else if (message == "Sil")
                {
                    DataAccess da = new DataAccess();
                    da.DeleteGenelBakim(ServisIDcb.Text);
                }
            }
        }

        private void ServisIDcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (message == "Duzenle")
            {
                DataAccess da = new DataAccess();
                List<GenelBakim> bakim = da.GetGenelBakim();
                foreach (GenelBakim x in bakim)
                {
                    if (ServisIDcb.Text == x.ServisID)
                    {
                        PersonelIDcb.Text = x.PersonelID;
                        UcakIDcb.Text = x.UcakID;
                        BakimTurutb.Text = x.BakimTuru;
                    }

                }
                BakimTurutb.Enabled = true;
            }
            if (message == "Sil")
            {
                DataAccess da = new DataAccess();
                List<GenelBakim> bakim = da.GetGenelBakim();
                foreach (GenelBakim x in bakim)
                {
                    if (ServisIDcb.Text == x.ServisID)
                    {
                        PersonelIDcb.Text = x.PersonelID;
                        UcakIDcb.Text = x.UcakID;
                        BakimTurutb.Text = x.BakimTuru;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
