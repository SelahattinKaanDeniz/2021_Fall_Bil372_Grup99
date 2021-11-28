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
    public partial class MurettebatPage : Form
    {
        public string message;
        List<Personel> personel;
        List<Ucak> ucak;
        public MurettebatPage(string msg)
        {
            InitializeComponent();
            message = msg;
            DataAccess da = new DataAccess();
            personel = new List<Personel>();
            ucak = new List<Ucak>();
            if (msg == "Ekle")
            {
                personel = da.getAtanmamisPersonelAdiMurettebat();
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
                personel = da.getAtanmisPersonelAdiMurettebat();
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
                personel = da.getAtanmisPersonelAdiMurettebat();
                for (int i = 0; i < personel.Count; i++)
                {
                    AdSoyadComboBox.Items.Add(personel[i].Ad + " " + personel[i].Soyad);

                }
            }
        }

        private void AdSoyadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel personelT = null;
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
            murettebatT = da.getMurettebat(personelT.PersonelID);
            
            if (message == "Ekle")
            {

                PersonelIDTextBox.Text = personelT.PersonelID;
            }
            if (message == "Düzenle")
            {

                MurettebatIDTextBox.Text = murettebatT[0].MurettebatID;
                UcakIDComboBox.Text = murettebatT[0].UcakID;
                PersonelIDTextBox.Text = murettebatT[0].PersonelID;
                YabanciDilTextBox.Text = murettebatT[0].YabanciDil;
                UcusSüresiTextBox.Text = murettebatT[0].UcusSuresi;
                MurettebatTipiTextBox.Text = murettebatT[0].MurettebatTipi;
                MurettebatIDTextBox.Enabled = false;
                PersonelIDTextBox.Enabled = false;
                UcakIDComboBox.Enabled = false;

            }
            else if (message == "Sil")
            {
                MurettebatIDTextBox.Text = murettebatT[0].MurettebatID;
                UcakIDComboBox.Text = murettebatT[0].UcakID;
                PersonelIDTextBox.Text = murettebatT[0].PersonelID;
                YabanciDilTextBox.Text = murettebatT[0].YabanciDil;
                UcusSüresiTextBox.Text = murettebatT[0].UcusSuresi;
                MurettebatTipiTextBox.Text = murettebatT[0].MurettebatTipi;
                MurettebatIDTextBox.Enabled = false;             
                PersonelIDTextBox.Enabled = false;
                YabanciDilTextBox.Enabled = false;
                UcusSüresiTextBox.Enabled = false;
                MurettebatTipiTextBox.Enabled = false;
                UcakIDComboBox.Enabled = false;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (message == "Ekle")
            {
                if (!(MurettebatIDTextBox.Text == string.Empty) && !(UcakIDComboBox.Text == string.Empty) && !(PersonelIDTextBox.Text == string.Empty)
                   && !(YabanciDilTextBox.Text == string.Empty) && !(UcusSüresiTextBox.Text == string.Empty) && !(AdSoyadComboBox.Text == string.Empty) && !(MurettebatTipiTextBox.Text == string.Empty))
                {
                    DataAccess da = new DataAccess();
                    da.EkleMurettebat(MurettebatIDTextBox.Text, UcakIDComboBox.Text, PersonelIDTextBox.Text, YabanciDilTextBox.Text, UcusSüresiTextBox.Text, MurettebatTipiTextBox.Text);
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
                    && !(YabanciDilTextBox.Text == string.Empty) && !(UcusSüresiTextBox.Text == string.Empty) && !(AdSoyadComboBox.Text == string.Empty) && !(MurettebatTipiTextBox.Text == string.Empty))
                    {
                        DataAccess da = new DataAccess();
                        da.UpdateMurettebat(MurettebatIDTextBox.Text, UcakIDComboBox.Text, PersonelIDTextBox.Text, YabanciDilTextBox.Text, UcusSüresiTextBox.Text, MurettebatTipiTextBox.Text);
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
                    da.DeleteUcak(MurettebatIDTextBox.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek Mürettebatın ID'sini seçiniz.");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

