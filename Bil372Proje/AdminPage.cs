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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();
            List<String> Names = new List<String>();
            Names = da.GetTableNames();
            for (int i = 0; i < Names.Count; i++)
            {
                AdminPageComboBox.Items.Add(Names[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EkleButton_Click(object sender, EventArgs e)
        {

        }

        private void DuzenleButton_Click(object sender, EventArgs e)
        {

        }

        private void SilButton_Click(object sender, EventArgs e)
        {

        }

        private void CikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }
    }
}
