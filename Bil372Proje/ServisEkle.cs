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
    public partial class ServisEkle : Form
    {
        public ServisEkle()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();
            List<Ucak> ucaklar = da.GetUcak();
            foreach(Ucak x in ucaklar)
            {
                UcakIDcb.Items.Add(x.UcakID);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UcakIDcb != null)
            {
                DataAccess da = new DataAccess();
                da.InsertServis(ServisIDtb.Text, UcakIDcb.Text, BaslangicTarihi.Value, BitisTarihi.Value, ServisTipitb.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
