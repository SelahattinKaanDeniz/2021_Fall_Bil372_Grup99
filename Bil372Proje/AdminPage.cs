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
            Islem(AdminPageComboBox.Text,"Ekle");
        }

        private void DuzenleButton_Click(object sender, EventArgs e)
        {
            Islem(AdminPageComboBox.Text, "Düzenle");
        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            Islem(AdminPageComboBox.Text, "Sil");
        }

        private void CikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }

        private void Islem(String pageName, String islem)
        {



            // passing string "str" in 
            // switch statement
            switch (pageName)
            {


                /* case "Personel":
                     PersonelPage f1 = new PersonelPage();
                     f1.ShowDialog();
                     break;
                 case "Kullanici":
                     KullaniciPage f2 = new KullaniciPage();
                     f2.ShowDialog();
                     break;*/

                /*
                case "Personel":
                    PersonelPage f1 = new PersonelPage();
                    f1.ShowDialog();
                    break;
                case "Kullanici":
                    KullaniciPage f2 = new KullaniciPage();
                    f2.ShowDialog();
                    break;

                case "Ucak":
                    if (islem == "Düzenle" || islem == "Sil")
                    {
                        UcakPage f3 = new UcakPage(islem);
                        f3.ShowDialog();
                        break;
                    }
                    else
                    {
                        UcakEklePage f3 = new UcakEklePage(islem);
                        f3.ShowDialog();
                        break;
                    }
            
                case "Murettebat":
                    MurettebatPage f4 = new MurettebatPage(islem);
                    f4.ShowDialog();
                    break;
               /* case "Pilot":
                    PilotPage f5 = new PilotPage();
                    f5.ShowDialog();
                    break;
                case "KabinMemuru":
                    KabinMemuruPage f6 = new KabinMemuruPage();
                    f6.ShowDialog();
                    break;
                case "Sefer":
                    SeferPage f7 = new SeferPage();
                    f7.ShowDialog();
                    break;
                case "Servis":
                    ServisPage f8 = new ServisPage();
                    f8.ShowDialog();
                    break;
                case "GenelBakim":
                    GenelBakimPage f9 = new GenelBakimPage();
                    f9.ShowDialog();
                    break;
                case "Tamir":
                    TamirPage f10 = new TamirPage();
                    f10.ShowDialog();
                    break;
                */case "TamirPersoneli":
                    TamirPersoneliPage f11 = new TamirPersoneliPage(islem);
                    f11.ShowDialog();
                    break;
            
                case "ServisPersoneli":
                    ServisPersoneliPage f12 = new ServisPersoneliPage(islem);
                    f12.ShowDialog();
                    break;
                case "GenelBakimTeknisyeni":
                    GenelBakimTeknisyeniPage f13 = new GenelBakimTeknisyeniPage(islem);
                    f13.ShowDialog();
                    break;
                default:

                   // GenelBakimTeknisyeniPage f13 = new GenelBakimTeknisyeniPage();
                   // f13.ShowDialog();
                    break;

                    /*GenelBakimTeknisyeniPage f13 = new GenelBakimTeknisyeniPage();
                    f13.ShowDialog();
                    break;*/

            }
                   
        }
    }
}
