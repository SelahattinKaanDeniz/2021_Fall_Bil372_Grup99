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
    public partial class SeferPage : Form
    {
        String message;
        public SeferPage(String m)
        {
            InitializeComponent();
            message = m;
            DataAccess da = new DataAccess();
            List<Sefer> seferler = da.GetSefer();
            foreach(Sefer x in seferler)
            {
                SeferIDcb.Items.Add(x.SeferID);
            }
            List<Ucak> ucaklar = da.GetUcak();
            foreach (Ucak x in ucaklar)
            {
                SeferIDcb.Items.Add(x.UcakID);
            }

            if (m.Equals("Sil"))
            {
                UcusSuresitb.Enabled = false;
                SeferTarihi.Enabled = false;
                UcakIDcb.Enabled = false;
                VarisZamanitb.Enabled = false;
                KalkisZamanitb.Enabled = false;
                VarisYeritb.Enabled =false;
                KalkisYeritb.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(message == "Sil"&& SeferIDcb.Text!=null)
            {
                DataAccess da = new DataAccess();
                da.DeleteSeferbyID(SeferIDcb.Text);
            }
            else if (message == "Duzenle" && SeferIDcb.Text != null)
            {
                DataAccess da = new DataAccess();
                da.UpdateSefer(SeferIDcb.Text, UcakIDcb.Text, UcusSuresitb.Text, SeferTarihi.Value, VarisZamanitb.Text, KalkisZamanitb.Text, VarisYeritb.Text, KalkisYeritb.Text);
            }
        }

        private void SeferIDcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(message == "Sil")
            {
                DataAccess da = new DataAccess();
                List<Sefer> seferler = da.GetSefer();
                foreach(Sefer x in seferler)
                {
                    if (x.SeferID == SeferIDcb.Text)
                    {
                        UcusSuresitb.Text = x.UcusSuresi;
                        SeferTarihi.Value = x.SeferTarihi;
                        UcakIDcb.Text = x.UcakID;
                        VarisZamanitb.Text = x.VarisZamani;
                        KalkisZamanitb.Text = x.KalkisZamani;
                        VarisYeritb.Text = x.VarisYeri;
                        KalkisYeritb.Text = x.KalkisYeri;
                    }
                }
            }
            if (message == "Duzenle")
            {
                DataAccess da = new DataAccess();
                List<Sefer> seferler = da.GetSefer();
                foreach (Sefer x in seferler)
                {
                    if (x.SeferID == SeferIDcb.Text)
                    {
                        UcusSuresitb.Text = x.UcusSuresi;
                        SeferTarihi.Value = x.SeferTarihi;
                        UcakIDcb.Text = x.UcakID;
                        VarisZamanitb.Text = x.VarisZamani;
                        KalkisZamanitb.Text = x.KalkisZamani;
                        VarisYeritb.Text = x.VarisYeri;
                        KalkisYeritb.Text = x.KalkisYeri;
                    }
                }
            }
        }
    }
}
