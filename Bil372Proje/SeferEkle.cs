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
    public partial class SeferEkle : Form
    {
        public SeferEkle()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();
            List<Ucak> ucak = new List<Ucak>();
            ucak = da.GetUcak();
            for (int i = 0; i < ucak.Count; i++)
            {
                UcakIDcb.Items.Add(ucak[i].UcakID);

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UcakIDcb != null)
            {
                DataAccess da = new DataAccess();
                da.InsertSefer(SeferIDtb.Text, UcakIDcb.Text, UcusSuresitb.Text, SeferTarihi.Value, KalkisZamanitb.Text, VarisZamanitb.Text, KalkisYeritb.Text, VarisYeritb.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
