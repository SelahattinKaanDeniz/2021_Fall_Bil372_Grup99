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
    public partial class PersonelEklePage : Form
    {
        public string message;
        List<Personel> personels;
        public PersonelEklePage(string msg)
        {
            InitializeComponent();
            
            message = msg;
            DataAccess da = new DataAccess();
            personels = new List<Personel>();
            personels = da.GetPersonel();          
            CinsiyetComboBox.Items.Add("erkek");
            CinsiyetComboBox.Items.Add("kadin");
            PersonelTipicb.Items.Add("Servis");
            PersonelTipicb.Items.Add("Kullanici");
            PersonelTipicb.Items.Add("Murettebat");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (message == "Ekle")
            {
                {
                    if (!(PersonelIDTextBox.Text == string.Empty) && !(CinsiyetComboBox.Text == string.Empty) && !(MaasTextBox.Text == string.Empty)
                    && !(DogumTarihidtp.Text == string.Empty) && !(AdTextBox.Text == string.Empty) && !(SoyadTextBox.Text == string.Empty)
                    && !(EgitimTextBox.Text == string.Empty) && !(TcnoTextBox.Text == string.Empty) && !(SgnTextBox.Text == string.Empty)
                    && !(İseAlimTarihidtp.Text == string.Empty) && !(TelefonNotb.Text == string.Empty) && !(Adrestb.Text == string.Empty)
                    && !(Epostatb.Text == string.Empty) && !(PersonelTipicb.Text == string.Empty))
                    {
                        DataAccess da = new DataAccess();
                        da.EklePersonel(PersonelIDTextBox.Text, CinsiyetComboBox.Text, MaasTextBox.Text, DogumTarihidtp.Value, AdTextBox.Text, SoyadTextBox.Text,
                           EgitimTextBox.Text, TcnoTextBox.Text, SgnTextBox.Text, İseAlimTarihidtp.Value, TelefonNotb.Text, Adrestb.Text, Epostatb.Text, PersonelTipicb.Text);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
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
