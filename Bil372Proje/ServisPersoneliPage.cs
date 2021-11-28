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
    public partial class ServisPersoneliPage : Form
    {
        public string message;
        List<ServisPersoneli> personel;
        public ServisPersoneliPage(string msg)
        {
            InitializeComponent();
            message = msg;
            DataAccess da = new DataAccess();
            /*DataAccess da = new DataAccess();
            personel = new List<ServisPersoneli>();
            personel = da.GetServisPersoneli();
            

            if (msg == "Ekle")
            {

                List<Personel> Personel = new List<Personel>();
                Personel = da.getAtanmamisPersonelAdiServis();
                for (int i = 0; i < Personel.Count; i++)
                {
                    servispersoneliadicb.Items.Add(Personel[i].Ad + " " + Personel[i].Soyad);
                }
            }
            else if (msg == "Düzenle")
            {
                List<Personel> Personel = new List<Personel>();
                Personel = da.getServisPersoneli();
                for (int i = 0; i < Personel.Count; i++)
                {
                    servispersoneliadicb.Items.Add(Personel[i].Ad + " " + Personel[i].Soyad);
                    Console.WriteLine(Personel[i].Ad + " " + Personel[i].Soyad);
                }
                onayla.Text = "Düzenle";
            }
            else if (msg == "Sil")
            {

            }*/
            Console.WriteLine('0');
            if (msg == "Ekle")
            {
                List<Personel> Personel = new List<Personel>();
                Personel = da.getAtanmamisPersonelAdiServis();
                for (int i = 0; i < Personel.Count; i++)
                {
                    if (Personel[i].PersonelTipi=="Servis") {
                        servispersoneliadicb.Items.Add(Personel[i].Ad+" "+Personel[i].Soyad);
                    }
                }

                onayla.Text = "Ekle";
            }
            else if (msg == "Düzenle")
            {
                Console.WriteLine('2');
                List<ServisPersoneli> Personel = new List<ServisPersoneli>();
                Personel = da.GetServisPersoneli();
                for (int i = 0; i < Personel.Count; i++)
                {
                    servispersoneliadicb.Items.Add(da.GetServisPersoneliAdi(Personel[i].PersonelID));
                }

                onayla.Text = "Düzenle";
            }
            else if (msg == "Sil")
            {
                List<ServisPersoneli> Personel = new List<ServisPersoneli>();
                Personel = da.GetServisPersoneli();
                for (int i = 0; i < Personel.Count; i++)
                {
                    servispersoneliadicb.Items.Add(da.GetServisPersoneliAdi(Personel[i].PersonelID));
                }

                onayla.Text = "Sil";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onayla.Text=="Ekle")
            {
                if (!(servispersoneliadicb.Text == string.Empty) && !(servispersonelicalistigihavalimanitb.Text == string.Empty) && !(servispersonelitipitb.Text == string.Empty)
                    && !(servispersonelspid.Text == string.Empty))
                {
                    DataAccess da = new DataAccess();
                    string[] temp = servispersoneliadicb.Text.Split(' ');
                    string id = da.getServisPersoneliIDbyName(temp[0], temp[1]);
                    da.EkleServisPersoneli(servispersonelspid.Text, servispersonelitipitb.Text, id, servispersonelicalistigihavalimanitb.Text);
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                }
            }
            if (onayla.Text == "Düzenle")
            {
                if (!(servispersoneliadicb.Text == string.Empty) && !(servispersonelicalistigihavalimanitb.Text == string.Empty) && !(servispersonelitipitb.Text == string.Empty)
                    && !(servispersonelspid.Text == string.Empty))
                {
                    DataAccess da = new DataAccess();
                    string[] temp = servispersoneliadicb.Text.Split(' ');
                    string id = da.getServisPersoneliIDbyName(temp[0], temp[1]);
                    da.UpdateServisPersoneli(servispersonelspid.Text, servispersonelitipitb.Text, id, servispersonelicalistigihavalimanitb.Text);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                }
            }
            if (onayla.Text == "Sil")
            {
                if (!(servispersoneliadicb.Text == string.Empty) && !(servispersonelicalistigihavalimanitb.Text == string.Empty) && !(servispersonelitipitb.Text == string.Empty)
                    && !(servispersonelspid.Text == string.Empty))
                {
                    DataAccess da = new DataAccess();
                    string[] temp = servispersoneliadicb.Text.Split(' ');
                    string id = da.getServisPersoneliIDbyName(temp[0], temp[1]);
                    da.DeleteServisPersoneli(servispersonelspid.Text);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                }
            }
        }

        private void servispersoneliadicb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (message == "Düzenle")
            {
                DataAccess da = new DataAccess();
                string[] temp = servispersoneliadicb.Text.Split(' ');
                string id = da.getServisPersoneliIDbyName(temp[0], temp[1]);
                List<ServisPersoneli> servispersoneli = da.GetServisPersoneli();
                foreach (ServisPersoneli sp in servispersoneli)
                {
                    if (sp.PersonelID == id)
                    {
                        servispersonelitipitb.Text = sp.ServisPersonelTipi;
                        servispersonelicalistigihavalimanitb.Text = sp.CalistigiHavalimani;
                        servispersonelspid.Text = sp.ServisPersoneliID;
                    }
                }
            }

            if (message == "Sil")
            {
                DataAccess da = new DataAccess();
                string[] temp = servispersoneliadicb.Text.Split(' ');
                string id = da.getServisPersoneliIDbyName(temp[0], temp[1]);
                List<ServisPersoneli> servispersoneli = da.GetServisPersoneli();
                foreach (ServisPersoneli sp in servispersoneli)
                {
                    if (sp.PersonelID == id)
                    {
                        servispersonelitipitb.Text = sp.ServisPersonelTipi;
                        servispersonelicalistigihavalimanitb.Text = sp.CalistigiHavalimani;
                        servispersonelspid.Text = sp.ServisPersoneliID;
                    }
                }
                servispersonelitipitb.Enabled = false;
                servispersonelicalistigihavalimanitb.Enabled = false;
                servispersonelspid.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
