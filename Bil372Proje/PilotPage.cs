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
    public partial class PilotPage : Form
    {
        public string message;
        List<Personel> personel;
        List<Ucak> ucak;
        public PilotPage(string msg)
        {
            InitializeComponent();
            message = msg;
            DataAccess da = new DataAccess();
            personel = new List<Personel>();
            ucak = new List<Ucak>();
            if (msg == "Ekle")
            {
                personel = da.getAtanmamisMurettebatAdiPilot();
                for (int i = 0; i < personel.Count; i++)
                {
                    AdSoyadComboBox.Items.Add(personel[i].Ad + " " + personel[i].Soyad);

                }
                ucak = da.GetUcak();
                for (int i = 0; i < ucak.Count; i++)
                {
                    UcakIDComboBox.Items.Add(ucak[i].UcakID);

                }
            }
            else if (msg == "Düzenle")
            {
                personel = da.getAtanmisMurettebatAdiPilot();
                for (int i = 0; i < personel.Count; i++)
                {
                    AdSoyadComboBox.Items.Add(personel[i].Ad + " " + personel[i].Soyad);

                }
                ucak = da.GetUcak();
                for (int i = 0; i < ucak.Count; i++)
                {
                    UcakIDComboBox.Items.Add(ucak[i].UcakID);

                }
            }
            else if (msg == "Sil")
            {
                personel = da.getAtanmisMurettebatAdiPilot();
                for (int i = 0; i < personel.Count; i++)
                {
                    AdSoyadComboBox.Items.Add(personel[i].Ad + " " + personel[i].Soyad);

                }
            }
        }

        private void AdSoyadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel personelT = null;
            List<Pilot> pilotT = null;
            List<Murettebat> murettebatT = null;
            for (int i = 0; i < personel.Count; i++)
            {
                if ((personel[i].Ad + " " + personel[i].Soyad).Equals(AdSoyadComboBox.Text))
                {
                    personelT = personel[i];
                    break;
                }
            }
            DataAccess da = new DataAccess();
            pilotT = da.getPilot(personelT.PersonelID);
            murettebatT = da.getMurettebat(personelT.PersonelID);
            if (message == "Ekle")
            {

                PersonelIDTextBox.Text = personelT.PersonelID;
                PersonelIDTextBox.Enabled = false;
                MurettebatIDTextBox.Text = murettebatT[0].MurettebatID;
                MurettebatIDTextBox.Enabled = false;
                UcakIDComboBox.Text = murettebatT[0].UcakID;
                UcakIDComboBox.Enabled = false;
            }
            if (message == "Düzenle")
            {

                MurettebatIDTextBox.Text = pilotT[0].MurettebatID;
                UcakIDComboBox.Text = pilotT[0].UcakID;
                PersonelIDTextBox.Text = pilotT[0].PersonelID;
                LisansTuruTextBox.Text = pilotT[0].LisansTuru;
                PilotRoluTextBox.Text = pilotT[0].PilotRolu;               
                MurettebatIDTextBox.Enabled = false;
                PersonelIDTextBox.Enabled = false;
                UcakIDComboBox.Enabled = false;

            }
            else if (message == "Sil")
            {
                MurettebatIDTextBox.Text = pilotT[0].MurettebatID;
                UcakIDComboBox.Text = pilotT[0].UcakID;
                PersonelIDTextBox.Text = pilotT[0].PersonelID;
                LisansTuruTextBox.Text = pilotT[0].LisansTuru;
                PilotRoluTextBox.Text = pilotT[0].PilotRolu;
                MurettebatIDTextBox.Enabled = false;
                PersonelIDTextBox.Enabled = false;
                LisansTuruTextBox.Enabled = false;
                PilotRoluTextBox.Enabled = false;
                UcakIDComboBox.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (message == "Ekle")
            {
                if (!(MurettebatIDTextBox.Text == string.Empty) && !(UcakIDComboBox.Text == string.Empty) && !(PersonelIDTextBox.Text == string.Empty)
                   && !(LisansTuruTextBox.Text == string.Empty) && !(PilotRoluTextBox.Text == string.Empty) && !(AdSoyadComboBox.Text == string.Empty) )
                {
                    DataAccess da = new DataAccess();
                    da.EklePilot(MurettebatIDTextBox.Text, UcakIDComboBox.Text, PersonelIDTextBox.Text, LisansTuruTextBox.Text, PilotRoluTextBox.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                }
            }

            else if (message == "Düzenle")
            {
                {
                    if (!(MurettebatIDTextBox.Text == string.Empty) && !(UcakIDComboBox.Text == string.Empty) && !(PersonelIDTextBox.Text == string.Empty)
                        && !(LisansTuruTextBox.Text == string.Empty) && !(PilotRoluTextBox.Text == string.Empty) && !(AdSoyadComboBox.Text == string.Empty))
                    {
                        DataAccess da = new DataAccess();
                        da.UpdatePilot(MurettebatIDTextBox.Text, UcakIDComboBox.Text, PersonelIDTextBox.Text, LisansTuruTextBox.Text, PilotRoluTextBox.Text);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                    }
                }
            }
            else if (message == "Sil")
            {
                if (!(AdSoyadComboBox.Text == string.Empty))
                {
                    DataAccess da = new DataAccess();
                    da.DeletePilot(MurettebatIDTextBox.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek Pilotun ID'sini seçiniz.");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
