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
    public partial class TamirPersoneliPage : Form
    {
        public string message;
        List<TamirPersoneli> personel;
        public TamirPersoneliPage(string msg)
        {
            InitializeComponent();
            message = msg;
            DataAccess da = new DataAccess();
            if (msg == "Ekle")
            {
                List<Personel> Personel = new List<Personel>();
                Personel = da.getAtanmamisServisPersoneliAdiTamirPersoneli();
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
                List<TamirPersoneli> Personel = new List<TamirPersoneli>();
                Personel = da.GetTamirPersoneli();
                for (int i = 0; i < Personel.Count; i++)
                {
                    PersonelAdicb.Items.Add(da.GetServisPersoneliAdi(Personel[i].PersonelID));
                }

                onayla.Text = "Düzenle";
            }
            else if (msg == "Sil")
            {
                List<TamirPersoneli> Personel = new List<TamirPersoneli>();
                Personel = da.GetTamirPersoneli();
                for (int i = 0; i < Personel.Count; i++)
                {
                    PersonelAdicb.Items.Add(da.GetServisPersoneliAdi(Personel[i].PersonelID));
                }

                onayla.Text = "Sil";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onayla.Text == "Ekle")
            {
                if (!(PersonelAdicb.Text == string.Empty) && !(comboBox1.Text == string.Empty) && !(Uzmanliktb.Text == string.Empty))
                {
                    DataAccess da = new DataAccess();
                    string[] temp = PersonelAdicb.Text.Split(' ');
                    string id = da.getTamirPersoneliIDbyName(temp[0], temp[1]);
                    da.EkleTamirPersoneli( comboBox1.Text,id,  Uzmanliktb.Text);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                }
            }
            if (onayla.Text == "Düzenle")
            {
                if (!(PersonelAdicb.Text == string.Empty) && !(comboBox1.Text == string.Empty) && !(Uzmanliktb.Text == string.Empty))
                {
                    DataAccess da = new DataAccess();
                    string[] temp = PersonelAdicb.Text.Split(' ');
                    string id = da.getTamirPersoneliIDbyName(temp[0], temp[1]);
                    da.UpdateTamirPersoneli(comboBox1.Text, id, Uzmanliktb.Text);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                }
            }
            if (onayla.Text == "Sil")
            {
                if (!(PersonelAdicb.Text == string.Empty) && !(comboBox1.Text == string.Empty) && !(Uzmanliktb.Text == string.Empty))
                {
                    DataAccess da = new DataAccess();
                    string[] temp = PersonelAdicb.Text.Split(' ');
                    string id = da.getPersonelIDbyName(temp[0], temp[1]);
                    Console.WriteLine(da.getServisPersonelIDbyPersonelID(id));
                    da.DeleteTamirPersoneli(da.getServisPersonelIDbyPersonelID(id));
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                }
            }
        }

        private void servispersoneliadicb_SelectedIndexChanged(object sender, EventArgs e)
        {   if(message == "Ekle")
            {
               
                    DataAccess da = new DataAccess();
                    string[] temp = PersonelAdicb.Text.Split(' ');
                    string id = da.getTamirPersoneliIDbyName(temp[0], temp[1]);
                    List<TamirPersoneli> TamirPersoneli = da.GetTamirPersoneli();
                    foreach (TamirPersoneli sp in TamirPersoneli)
                    {
                        if (sp.PersonelID == id)
                        {
                            Uzmanliktb.Text = sp.Uzmanlik;
                            comboBox1.Text = sp.ServisPersoneliID;
                        }
                    }

                    List<Personel> Personel = new List<Personel>();
                    Personel = da.getAtanmamisServisPersoneliAdiTamirPersoneli();
                    comboBox1.Items.Clear();
                    for (int i = 0; i < Personel.Count; i++)
                    {

                        comboBox1.Items.Add(da.getServisPersonelIDbyPersonelID(Personel[i].PersonelID));
                    }


                
            }
            else if (message == "Düzenle")
            {
                DataAccess da = new DataAccess();
                string[] temp = PersonelAdicb.Text.Split(' ');
                string id = da.getTamirPersoneliIDbyName(temp[0], temp[1]);
                List<TamirPersoneli> TamirPersoneli = da.GetTamirPersoneli();
                foreach (TamirPersoneli sp in TamirPersoneli)
                {
                    if (sp.PersonelID == id)
                    {
                        Uzmanliktb.Text= sp.Uzmanlik;
                        comboBox1.Text = sp.ServisPersoneliID;
                    }
                }

                List<Personel> Personel = new List<Personel>();
                Personel = da.getAtanmamisServisPersoneliAdiTamirPersoneli();
                comboBox1.Items.Clear();
                for (int i = 0; i < Personel.Count; i++)
                {
                    
                    comboBox1.Items.Add(da.getServisPersonelIDbyPersonelID(Personel[i].PersonelID));
                }


            }

            if (message == "Sil")
            {
                DataAccess da = new DataAccess();
                string[] temp = PersonelAdicb.Text.Split(' ');
                string id = da.getTamirPersoneliIDbyName(temp[0], temp[1]);
                List<TamirPersoneli> TamirPersoneli = da.GetTamirPersoneli();
                foreach (TamirPersoneli sp in TamirPersoneli)
                {
                    if (sp.PersonelID == id)
                    {
                        Uzmanliktb.Text = sp.Uzmanlik;
                        comboBox1.Text = sp.ServisPersoneliID;
                    }
                }
                List<Personel> Personel = new List<Personel>();
                Personel = da.getAtanmamisServisPersoneliAdiTamirPersoneli();
                comboBox1.Items.Clear();
                for (int i = 0; i < Personel.Count; i++)
                {

                    comboBox1.Items.Add(da.getServisPersonelIDbyPersonelID(Personel[i].PersonelID));
                }
                comboBox1.Enabled = false;
                Uzmanliktb.Enabled = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
