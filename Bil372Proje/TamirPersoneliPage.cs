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
        string message;
        public TamirPersoneliPage(string msg)
        {
            message = msg;
            DataAccess da = new DataAccess();
            InitializeComponent();
            if (msg == "Ekle")
            {
                
                List<Personel> Personel = new List<Personel>();
                Personel = da.getAtanmamisPersonelAdiServis();
                for (int i = 0; i < Personel.Count; i++)
                {
                    PersonelAdicb.Items.Add(Personel[i].Ad+ " "+Personel[i].Soyad);
                }
            }
            else if (msg == "Düzenle")
            {
                List<Personel> Personel = new List<Personel>();
                Personel = da.getTamirPersoneliAtanmisAdi();
                for (int i = 0; i < Personel.Count; i++)
                {
                    PersonelAdicb.Items.Add(Personel[i].Ad + " " + Personel[i].Soyad);
                }
                onayla.Text = "Düzenle";
            }
            else if(msg == "Sil")
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PersonelAdicb.Text != null && Uzmanliktb.Text!=null)
            {
                DataAccess da = new DataAccess();
                List<Personel> Personel = new List<Personel>();
                Personel = da.getAtanmamisPersonelAdiServis();
                string[] temp = PersonelAdicb.Text.Split(' ');
                da.InsertTamirPersoneli(da.getPersonelIDbyName(temp[0], temp[1]),Uzmanliktb.Text);
                
            }



        }

        private void PersonelAdicb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (message != "Ekle") { 
                DataAccess da = new DataAccess();
                List<Personel> Personel = new List<Personel>();
                string[] temp = PersonelAdicb.Text.Split(' ');
                Uzmanliktb.Text = da.getTamirPersoneliUzmanlikByID(da.getTamirPersoneliIDbyName(temp[0], temp[1]));
            }
        }
    }
}
