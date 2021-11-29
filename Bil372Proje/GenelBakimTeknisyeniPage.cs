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
    public partial class GenelBakimTeknisyeniPage : Form
    {
        public string message;
        List<GenelBakimTeknisyeni> personel;
        public GenelBakimTeknisyeniPage(string msg)
        {
            InitializeComponent();
            message = msg;
            DataAccess da = new DataAccess();
            if (msg == "Ekle")
            {
                List<Personel> Personel = new List<Personel>();
                Personel = da.getAtanmamisServisPersoneliAdiGenelBakimTeknisyeni();
                for (int i = 0; i < Personel.Count; i++)
                {
                    if (Personel[i].PersonelTipi == "Servis")
                    {
                        PersonelAdicb.Items.Add(Personel[i].Ad + " " + Personel[i].Soyad);
                    }
                }

                onayla.Text = "Ekle";
            }
            else if (msg == "Düzenle")
            {
                Console.WriteLine('2');
                List<GenelBakimTeknisyeni> Personel = new List<GenelBakimTeknisyeni>();
                Personel = da.GetGenelBakimTeknisyeni();
                for (int i = 0; i < Personel.Count; i++)
                {
                    PersonelAdicb.Items.Add(da.GetServisPersoneliAdi(Personel[i].PersonelID));
                }

                onayla.Text = "Düzenle";
            }
            else if (msg == "Sil")
            {
                List<GenelBakimTeknisyeni> Personel = new List<GenelBakimTeknisyeni>();
                Personel = da.GetGenelBakimTeknisyeni();
                for (int i = 0; i < Personel.Count; i++)
                {
                    PersonelAdicb.Items.Add(da.GetServisPersoneliAdi(Personel[i].PersonelID));
                }

                onayla.Text = "Sil";
            }
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            if (onayla.Text == "Ekle")
            {
                if (!(PersonelAdicb.Text == string.Empty) && !(comboBox1.Text == string.Empty) && !(teknisyenderecesitb.Text == string.Empty))
                {
                    DataAccess da = new DataAccess();
                    string[] temp = PersonelAdicb.Text.Split(' ');
                    string id = da.getGenelBakimTeknisyeniIDbyName(temp[0], temp[1]);
                    da.EkleGenelBakimTeknisyeni(comboBox1.Text, id, teknisyenderecesitb.Text);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                }
            }
            if (onayla.Text == "Düzenle")
            {
                if (!(PersonelAdicb.Text == string.Empty) && !(comboBox1.Text == string.Empty) && !(teknisyenderecesitb.Text == string.Empty))
                {
                    DataAccess da = new DataAccess();
                    string[] temp = PersonelAdicb.Text.Split(' ');
                    string id = da.getGenelBakimTeknisyeniIDbyName(temp[0], temp[1]);
                    da.UpdateGenelBakimTeknisyeni(comboBox1.Text, id, teknisyenderecesitb.Text);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                }
            }
            if (onayla.Text == "Sil")
            {
                if (!(PersonelAdicb.Text == string.Empty) && !(comboBox1.Text == string.Empty) && !(teknisyenderecesitb.Text == string.Empty))
                {
                    DataAccess da = new DataAccess();
                    string[] temp = PersonelAdicb.Text.Split(' ');
                    string id = da.getGenelBakimTeknisyeniIDbyName(temp[0], temp[1]);
                    Console.WriteLine(da.getServisPersonelIDbyPersonelID(id));
                    da.DeleteGenelBakimTeknisyeni(da.getServisPersonelIDbyPersonelID(id));
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                }
            }
        }

        private void PersonelAdicb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (message == "Ekle")
            {
                DataAccess da = new DataAccess();
                string[] temp = PersonelAdicb.Text.Split(' ');
                string id = da.getGenelBakimTeknisyeniIDbyName(temp[0], temp[1]);
                List<GenelBakimTeknisyeni> GenelBakimTeknisyeni = da.GetGenelBakimTeknisyeni();
                foreach (GenelBakimTeknisyeni sp in GenelBakimTeknisyeni)
                {
                    if (sp.PersonelID == id)
                    {
                        teknisyenderecesitb.Text = sp.TeknisyenDerecesi;
                        comboBox1.Text = sp.ServisPersoneliID;
                    }
                }

                List<Personel> Personel = new List<Personel>();
                Personel = da.getAtanmamisServisPersoneliAdiGenelBakimTeknisyeni();
                comboBox1.Items.Clear();
                for (int i = 0; i < Personel.Count; i++)
                {

                    comboBox1.Items.Add(da.getServisPersonelIDbyPersonelID(Personel[i].PersonelID));
                }


            }
            if (message == "Düzenle")
            {
                DataAccess da = new DataAccess();
                string[] temp = PersonelAdicb.Text.Split(' ');
                string id = da.getGenelBakimTeknisyeniIDbyName(temp[0], temp[1]);
                List<GenelBakimTeknisyeni> GenelBakimTeknisyeni = da.GetGenelBakimTeknisyeni();
                foreach (GenelBakimTeknisyeni sp in GenelBakimTeknisyeni)
                {
                    if (sp.PersonelID == id)
                    {
                        teknisyenderecesitb.Text = sp.TeknisyenDerecesi;
                        comboBox1.Text = sp.ServisPersoneliID;
                    }
                }

                List<Personel> Personel = new List<Personel>();
                Personel = da.getAtanmamisServisPersoneliAdiGenelBakimTeknisyeni();
                comboBox1.Items.Clear();
                for (int i = 0; i < Personel.Count; i++)
                {

                    comboBox1.Items.Add(da.getServisPersonelIDbyPersonelID(Personel[i].PersonelID));
                }
                comboBox1.Enabled = false;
                

            }

            if (message == "Sil")
            {
                DataAccess da = new DataAccess();
                string[] temp = PersonelAdicb.Text.Split(' ');
                string id = da.getGenelBakimTeknisyeniIDbyName(temp[0], temp[1]);
                List<GenelBakimTeknisyeni> GenelBakimTeknisyeni = da.GetGenelBakimTeknisyeni();
                foreach (GenelBakimTeknisyeni sp in GenelBakimTeknisyeni)
                {
                    if (sp.PersonelID == id)
                    {
                        teknisyenderecesitb.Text = sp.TeknisyenDerecesi;
                        comboBox1.Text = sp.ServisPersoneliID;
                    }
                }
                List<Personel> Personel = new List<Personel>();
                Personel = da.getAtanmamisServisPersoneliAdiGenelBakimTeknisyeni();
                comboBox1.Items.Clear();
                for (int i = 0; i < Personel.Count; i++)
                {

                    comboBox1.Items.Add(da.getServisPersonelIDbyPersonelID(Personel[i].PersonelID));
                }
                comboBox1.Enabled = false;
                teknisyenderecesitb.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
