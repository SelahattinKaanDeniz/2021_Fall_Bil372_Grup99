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
    public partial class ServisYoneticisiPage : Form
    {
        public ServisYoneticisiPage()
        {
            InitializeComponent();
            comboBox1.Items.Add("Servis");
            comboBox1.Items.Add("Tamir");
            comboBox1.Items.Add("GenelBakim");
            listView1.View = View.Details;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            DataAccess da = new DataAccess();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            DateTime today = DateTime.Now;

            List<Servis> servisler = da.GetServis();
            foreach (Servis x in servisler)
            {
                if (x.BitisTarihi > today)
                {
                    TimeSpan daysleft = x.BitisTarihi.Subtract(today);
                    listView1.Items.Add("ServisID: "+x.ServisID+" Servis Tipi "+x.ServisTipi+" Kalan Gun "+daysleft.Days);
                }
            }
        }

        private void ServisYoneticisiPage_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
