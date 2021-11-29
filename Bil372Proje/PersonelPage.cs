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
    public partial class PersonelPage : Form
    {
        public string message;
        List<Personel> personels;
        public PersonelPage(string msg)
        {
            InitializeComponent();
            message = msg;
            DataAccess da = new DataAccess();
            personels = new List<Personel>();
            personels = da.GetPersonel();
            for (int i = 0; i < personels.Count; i++)
            {
                PersonelIDComboBox.Items.Add(personels[i].PersonelID);

            }
            CinsiyetComboBox.Items.Add("erkek");
            CinsiyetComboBox.Items.Add("kadin");
            PersonelTipicb.Items.Add("Servis");
            PersonelTipicb.Items.Add("Kullanici");
            PersonelTipicb.Items.Add("Murettebat");

        }

        private void PersonelIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel personelT = null;
            for (int i = 0; i < personels.Count; i++)
            {
                if (personels[i].PersonelID.Equals(PersonelIDComboBox.Text))
                {
                    personelT = personels[i];
                    break;
                }
            }

            if (message == "Düzenle")
            {

                CinsiyetComboBox.Text = personelT.Cinsiyet;
                MaasTextBox.Text = personelT.Maas;
                DogumTarihidtp.Value = personelT.DogumTarihi;
                AdTextBox.Text = personelT.Ad;
                SoyadTextBox.Text = personelT.Soyad;
                EgitimTextBox.Text = personelT.Egitim;
                TcnoTextBox.Text = personelT.TCNO;
                SgnTextBox.Text = personelT.SGN;
                İseAlimTarihidtp.Value = personelT.IseAlimTarihi;
                TelefonNotb.Text = personelT.TelefonNO;
                Adrestb.Text = personelT.Adres;
                Epostatb.Text = personelT.EPosta;
                PersonelTipicb.Text = personelT.PersonelTipi;

            }
            else if (message == "Sil")
            {
                CinsiyetComboBox.Text = personelT.Cinsiyet;
                MaasTextBox.Text = personelT.Maas;
                DogumTarihidtp.Value = personelT.DogumTarihi;
                AdTextBox.Text = personelT.Ad;
                SoyadTextBox.Text = personelT.Soyad;
                EgitimTextBox.Text = personelT.Egitim;
                TcnoTextBox.Text = personelT.TCNO;
                SgnTextBox.Text = personelT.SGN;
                İseAlimTarihidtp.Value = personelT.IseAlimTarihi;
                TelefonNotb.Text = personelT.TelefonNO;
                Adrestb.Text = personelT.Adres;
                Epostatb.Text = personelT.EPosta;
                PersonelTipicb.Text = personelT.PersonelTipi;

                CinsiyetComboBox.Enabled = false;
                MaasTextBox.Enabled = false;
                DogumTarihidtp.Enabled = false;
                AdTextBox.Enabled = false;
                SoyadTextBox.Enabled = false;
                EgitimTextBox.Enabled = false;
                TcnoTextBox.Enabled = false;
                SgnTextBox.Enabled = false;
                İseAlimTarihidtp.Enabled = false;
                TelefonNotb.Enabled = false;
                Adrestb.Enabled = false;
                Epostatb.Enabled = false;
                PersonelTipicb.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (message == "Düzenle")
            {
                {
                    if (!(PersonelIDComboBox.Text == string.Empty) && !(CinsiyetComboBox.Text == string.Empty) && !(MaasTextBox.Text == string.Empty)
                    && !(DogumTarihidtp.Text == string.Empty) && !(AdTextBox.Text == string.Empty) && !(SoyadTextBox.Text == string.Empty)
                    && !(EgitimTextBox.Text == string.Empty) && !(TcnoTextBox.Text == string.Empty) && !(SgnTextBox.Text == string.Empty)
                    && !(İseAlimTarihidtp.Text == string.Empty) && !(TelefonNotb.Text == string.Empty) && !(Adrestb.Text == string.Empty)
                    && !(Epostatb.Text == string.Empty) && !(PersonelTipicb.Text == string.Empty))
                    {
                        DataAccess da = new DataAccess();
                        da.UpdatePersonel(PersonelIDComboBox.Text, CinsiyetComboBox.Text, MaasTextBox.Text, DogumTarihidtp.Value, AdTextBox.Text, SoyadTextBox.Text,
                           EgitimTextBox.Text, TcnoTextBox.Text, SgnTextBox.Text, İseAlimTarihidtp.Value, TelefonNotb.Text, Adrestb.Text, Epostatb.Text, PersonelTipicb.Text);
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
                if (!(PersonelIDComboBox.Text == string.Empty))
                {
                    DataAccess da = new DataAccess();
                    da.DeletePersonel(PersonelIDComboBox.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek Uçağın ID'sini seçiniz.");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
