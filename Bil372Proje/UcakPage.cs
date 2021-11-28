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
    public partial class UcakPage : Form
    {
        public string message;
        List<Ucak> ucak;
        public UcakPage(string msg)
        {
            InitializeComponent();
            message = msg;
            DataAccess da = new DataAccess();
            ucak = new List<Ucak>();
            ucak = da.GetUcak();
            for (int i = 0; i < ucak.Count; i++)
            {
                UcakIDComboBox.Items.Add(ucak[i].UcakID);
               
            }
           
        }
        private void UcakIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (message == "Düzenle")
            {
                {
                    if (!(ModelTextBox.Text == string.Empty) && !(AgirlikTextBox.Text == string.Empty) && !(YolcuKapasitesiTextBox.Text == string.Empty)
                    && !(UreticiFirmaTextBox.Text == string.Empty) && !(UretimYili.Text == string.Empty) && !(UcakIDComboBox.Text == string.Empty))
                    {
                        DataAccess da = new DataAccess();
                        da.UpdateUcak(UcakIDComboBox.Text, ModelTextBox.Text, YolcuKapasitesiTextBox.Text, AgirlikTextBox.Text, UreticiFirmaTextBox.Text, UretimYili.Text);
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
                if (!(UcakIDComboBox.Text == string.Empty)){
                    DataAccess da = new DataAccess();
                    da.DeleteUcak(UcakIDComboBox.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek Uçağın ID'sini seçiniz.");
                }

            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UcakIDComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
            Ucak ucakT = null;
            for (int i = 0; i < ucak.Count; i++)
            {
                if (ucak[i].UcakID.Equals(UcakIDComboBox.Text))
                {
                    ucakT = ucak[i];
                    break;
                }
            }

            if (message == "Düzenle")
            {

                ModelTextBox.Text = ucakT.Model;
                YolcuKapasitesiTextBox.Text = ucakT.YolcuKapasitesi;
                AgirlikTextBox.Text = ucakT.Agirlik;
                UreticiFirmaTextBox.Text = ucakT.UreticiFirma;
                UretimYili.Text = ucakT.UretimYili;
            }
            else if (message == "Sil")
            {
                ModelTextBox.Text = ucakT.Model;
                YolcuKapasitesiTextBox.Text = ucakT.YolcuKapasitesi;
                AgirlikTextBox.Text = ucakT.Agirlik;
                UreticiFirmaTextBox.Text = ucakT.UreticiFirma;
                UretimYili.Text = ucakT.UretimYili;

                ModelTextBox.Enabled = false;
                YolcuKapasitesiTextBox.Enabled = false;
                AgirlikTextBox.Enabled = false;
                UreticiFirmaTextBox.Enabled = false;
                UretimYili.Enabled = false;
            }
        }
    }
}
