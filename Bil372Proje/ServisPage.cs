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
    public partial class ServisPage : Form
    {
        String message;
        public ServisPage(String m)
        {
            message = m;
            InitializeComponent();
            ServisTipicb.Items.Add("GenelBakim");
            ServisTipicb.Items.Add("Tamir");
            DataAccess da = new DataAccess();
            List<Servis> servis = da.GetServis();
            foreach(Servis x in servis)
            {
                ServisIDcb.Items.Add(x.ServisID);
            }
            List<Ucak> ucaklar = da.GetUcak();
            foreach (Ucak x in ucaklar)
            {
                UcakIDcb.Items.Add(x.UcakID);
            }
            UcakIDcb.Enabled = false;
            ServisTipicb.Enabled = false;
            BaslangicTarihi.Enabled = false;
            BitisTarihi.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ServisIDcb.Text != null)
            {
                if(message == "Düzenle")
                {
                    DataAccess da = new DataAccess();
                    da.UpdateServis(ServisIDcb.Text, UcakIDcb.Text, BaslangicTarihi.Value, BitisTarihi.Value, ServisTipicb.Text);
                    this.Close();
                }
                else if(message == "Sil")
                {
                    DataAccess da = new DataAccess();
                    da.DeleteServis(ServisIDcb.Text);
                    this.Close();
                }
            }
        }

        private void ServisIDcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (message == "Düzenle")
            {
                UcakIDcb.Enabled = true;
                ServisTipicb.Enabled = true;
                BaslangicTarihi.Enabled = true;
                BitisTarihi.Enabled = true ;
                DataAccess da = new DataAccess();
                List<Servis> servis = da.GetServis();
                foreach (Servis x in servis)
                {
                    if (x.ServisID == ServisIDcb.Text)
                    {
                        UcakIDcb.Text = x.UcakID;
                        ServisTipicb.Text = x.ServisTipi;
                        BaslangicTarihi.Value = x.BaslangicTarihi;
                        BitisTarihi.Value = x.BitisTarihi;

                    }
                }
            }
            else if (message == "Sil")
            {
                DataAccess da = new DataAccess();
                List<Servis> servis = da.GetServis();
                foreach (Servis x in servis)
                {
                    if (x.ServisID == ServisIDcb.Text)
                    {
                        UcakIDcb.Text = x.UcakID;
                        ServisTipicb.Text = x.ServisTipi;
                        BaslangicTarihi.Value = x.BaslangicTarihi;
                        BitisTarihi.Value = x.BitisTarihi;

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
