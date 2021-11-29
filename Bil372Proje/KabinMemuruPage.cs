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
    public partial class KabinMemuruPage : Form
    {
        public string message;
        List<Personel> personel;
        List<Ucak> ucak;
        public KabinMemuruPage(string msg)
        {
            InitializeComponent();
            message = msg;
            DataAccess da = new DataAccess();
            personel = new List<Personel>();
            ucak = new List<Ucak>();
            if (msg == "Ekle")
            {
                personel = da.getAtanmamisMurettebatAdiKabinMemuru();
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
                personel = da.getAtanmisMurettebatAdiKabinMemuru();
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
                personel = da.getAtanmisMurettebatAdiKabinMemuru();
                for (int i = 0; i < personel.Count; i++)
                {
                    AdSoyadComboBox.Items.Add(personel[i].Ad + " " + personel[i].Soyad);

                }
            }

        }

        private void AdSoyadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel personelT = null;
            List<KabinMemuru> kabinMemuruT = null;
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
            kabinMemuruT = da.getKabinMemuru(personelT.PersonelID);
            murettebatT = da.getMurettebat(personelT.PersonelID);
            if (message == "Ekle")
            {

                PersonelIDTextBox.Text = personelT.PersonelID;
                PersonelIDTextBox.Enabled = false;
                MurettebatIDTextBox.Text = murettebatT[0].MurettebatID;
                MurettebatIDTextBox.Enabled = false;
                UcakIDComboBox.Text= murettebatT[0].UcakID;
                UcakIDComboBox.Enabled = false;
            }
            if (message == "Düzenle")
            {

                MurettebatIDTextBox.Text = kabinMemuruT[0].MurettebatID;
                UcakIDComboBox.Text = kabinMemuruT[0].UcakID;
                PersonelIDTextBox.Text = kabinMemuruT[0].PersonelID;
                MedeniDurumuTextBox.Text = kabinMemuruT[0].MedeniDurumu;            
                MurettebatIDTextBox.Enabled = false;
                PersonelIDTextBox.Enabled = false;
                UcakIDComboBox.Enabled = false;

            }
            else if (message == "Sil")
            {
                MurettebatIDTextBox.Text = kabinMemuruT[0].MurettebatID;
                UcakIDComboBox.Text = kabinMemuruT[0].UcakID;
                PersonelIDTextBox.Text = kabinMemuruT[0].PersonelID;
                MedeniDurumuTextBox.Text = kabinMemuruT[0].MedeniDurumu;
                MurettebatIDTextBox.Enabled = false;
                PersonelIDTextBox.Enabled = false;
                UcakIDComboBox.Enabled = false;
                MedeniDurumuTextBox.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (message == "Ekle")
            {
                if (!(MurettebatIDTextBox.Text == string.Empty) && !(UcakIDComboBox.Text == string.Empty) && !(PersonelIDTextBox.Text == string.Empty)
                   && !(MedeniDurumuTextBox.Text == string.Empty)  && !(AdSoyadComboBox.Text == string.Empty))
                {
                    DataAccess da = new DataAccess();
                    da.EkleKabinMemuru(MurettebatIDTextBox.Text, UcakIDComboBox.Text, PersonelIDTextBox.Text, MedeniDurumuTextBox.Text);
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
                        && !(MedeniDurumuTextBox.Text == string.Empty)  && !(AdSoyadComboBox.Text == string.Empty))
                    {
                        DataAccess da = new DataAccess();
                        da.UpdateKabinMemuru(MurettebatIDTextBox.Text, UcakIDComboBox.Text, PersonelIDTextBox.Text, MedeniDurumuTextBox.Text);
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
                    da.DeleteKabinMemuru(MurettebatIDTextBox.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek Kabin Memur'unun ID'sini seçiniz.");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
