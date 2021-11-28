using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil372ProjeGrup99
{
    public partial class SeferYoneticisiPage : Form
    {
        public SeferYoneticisiPage()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            DateTime today = DateTime.Now;
            List <Sefer> seferler = da.GetSefer();
            foreach (Sefer x in seferler)
            {
                if (x.SeferTarihi > today)
                {
                    TimeSpan daysleft = x.SeferTarihi.Subtract(today);
                    listView1.Items.Add(x.KalkisYeri + "-" + x.VarisYeri + "  " + x.KalkisZamani + "  " + daysleft.Days + " gun sonra");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeferEkle newscreen = new SeferEkle();
            newscreen.ShowDialog();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeferPage newscreen = new SeferPage("Duzenle");
            newscreen.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeferPage newscreen = new SeferPage("Sil");
            newscreen.ShowDialog();
        }
    }
}
