using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Bil372ProjeGrup99
{
    class DataAccess
    {
        public void InsertPersonel()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {

            }
        }
        public Boolean MatchKullaniciAdi(String KullaniciAdi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                Boolean result = false;
                var output = connection.Query<Kullanici>($"select KullaniciAdi from Kullanici where KullaniciAdi= '" + KullaniciAdi + "'").ToList();
                if (output.Count > 0)
                    result = true;
                return result;
            }
        }
        public Boolean MatchSifre(String Sifre)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                Boolean result = false;
                var output = connection.Query<Kullanici>($"select Sifre from Kullanici where Sifre= '" + Sifre + "'").ToList();
                if (output.Count > 0)
                    result = true;
                return result;
            }
        }
        public String GetKullaniciTipi(String KullaniciAdi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Kullanici>($"select * from Kullanici where KullaniciAdi= '" + KullaniciAdi + "'").ToList();
                return output[0].KullaniciTipi;
            }
        }


        public List<String> GetTableNames()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<String>($"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'BİL372'; ").ToList();
                return output;
            }
        }
        public List<Personel> getAtanmamisPersonelAdiServis()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Personel>($"select Ad, Soyad,PersonelID from Personel where not exists(select  Ad, Soyad from Murettebat ) and not exists(select Ad, Soyad from ServisPersoneli) and PersonelTipi = 'Servis'").ToList();
                return output;
            }


        }
        public void InsertTamirPersoneli(string PersonelID, string Uzmanlik)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                TamirPersoneli tamirPersonel = new TamirPersoneli();
                tamirPersonel.PersonelID = PersonelID;
                tamirPersonel.Uzmanlik = Uzmanlik;
                string sql = "INSERT INTO tamirPersoneli  Values (@PersonelID,@Uzmanlik);";
                connection.Execute(sql, tamirPersonel);
            }


        }

        public String getPersonelIDbyName(string Ad, string Soyad)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Personel>($"select PersonelID from Personel where Ad='{Ad}' and Soyad='{Soyad}'").ToList();
                
                return output[0].PersonelID;
            }


        }

        public List<Personel> getTamirPersoneliAtanmisAdi()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Personel>($"select Ad, Soyad,Personel.PersonelID,TamirPersoneli.Uzmanlik from Personel,TamirPersoneli where Personel.PersonelID=TamirPersoneli.PersonelID" ).ToList();
                return output;
            }


        }

        public List<Ucak> GetUcak()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Ucak>($"select * from Ucak; ").ToList();
                return output;
            }
        }
        public void UpdateUcak(string ucakID, string model, string yolcukapasitesi, string agirlik, string ureticifirma, string uretimyili)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "UPDATE Ucak SET Model='" + model + "', Yolcukapasitesi='" + yolcukapasitesi + "', Agirlik='" + agirlik + "', UreticiFirma='" + ureticifirma + "', UretimYili='" + uretimyili + "' WHERE UcakID='" + ucakID + "'";

                connection.Execute(querystr);

            }
        }

        public void DeleteUcak(string ucakID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "DELETE FROM Ucak WHERE UcakID='" + ucakID + "'";
                connection.Execute(querystr);

            }
        }

        public void EkleUcak(string ucakID, string model, string yolcukapasitesi, string agirlik, string ureticifirma, string uretimyili)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string sql = "INSERT INTO Ucak (UcakID, Model, YolcuKapasitesi,Agirlik, UreticiFirma, UretimYili) Values (@UcakID, @Model , @YolcuKapasitesi , @Agirlik , @UreticiFirma , @UretimYili );";

                Ucak ucak = new Ucak { UcakID = ucakID, Model = model, YolcuKapasitesi = yolcukapasitesi, Agirlik = agirlik, UreticiFirma = ureticifirma, UretimYili = uretimyili };
                connection.Execute(sql, ucak);


            }
        }



        public String getTamirPersoneliUzmanlikByID(string ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<TamirPersoneli>($"select Uzmanlik from TamirPersoneli where PersonelID='{ID}' ").ToList();

                return output[0].Uzmanlik;
            }


        }

        public String getTamirPersoneliIDbyName(string Ad,string Soyad)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Personel>($"select PersonelID from Personel where Personel.Ad='{Ad}' and Personel.Soyad='{Soyad}' ").ToList();

                return output[0].PersonelID;
            }
        }
        public List<Personel> getAtanmamisPersonelAdiMurettebat()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Personel>($"select Ad, Soyad,Personel.PersonelID from Personel where not exists(select Murettebat.PersonelID from Murettebat where Murettebat.PersonelID=Personel.PersonelID ) and not exists(select ServisPersoneli.PersonelID from ServisPersoneli where ServisPersoneli.PersonelID=Personel.PersonelID) and PersonelTipi = 'Murettebat'").ToList();
                return output;
            }
        }

        public List<Personel> getAtanmisPersonelAdiMurettebat()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Personel>($"select Ad, Soyad,Personel.PersonelID from Personel,Murettebat where Murettebat.PersonelID=Personel.PersonelID").ToList();
                return output;
            }
        }

        public List<Murettebat> getMurettebat(string ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Murettebat>($"select * from Murettebat where PersonelID='" + ID + "' ").ToList();

                return output;

            }


        }


        public void UpdateTamirPersoneli(string PersonelID, string Uzmanlik)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                TamirPersoneli tamirPersonel = new TamirPersoneli();
                tamirPersonel.PersonelID = PersonelID;
                tamirPersonel.Uzmanlik = Uzmanlik;
                string sql = "INSERT INTO tamirPersoneli  Values (@PersonelID,@Uzmanlik);";
                connection.Execute(sql, tamirPersonel);
            }


        }
        public List<Sefer> GetSefer()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Sefer>($"SELECT * FROM Sefer").ToList();
                return output;
            }
        }
        public void InsertSefer(String seferid,String ucakid,String ucussuresi,DateTime sefertarihi,String kalkiszamani,String variszamani,String kalkisyeri,String varisyeri)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                Sefer sefer = new Sefer();
                sefer.SeferID = seferid;
                sefer.UcakID = ucakid;
                sefer.UcusSuresi = ucussuresi;
                sefer.SeferTarihi = sefertarihi;
                sefer.KalkisZamani = kalkiszamani;
                sefer.VarisZamani = variszamani;
                sefer.KalkisYeri = kalkisyeri;
                sefer.VarisYeri = varisyeri;
                string sql = "INSERT INTO Sefer (SeferID,UcakID,UcusSuresi,SeferTarihi,VarisZamani,KalkisZamani,VarisYeri,KalkisYeri) Values (@SeferID,@UcakID,@UcusSuresi,@SeferTarihi,@VarisZamani,@KalkisZamani,@VarisYeri,@KalkisYeri);";
                connection.Execute(sql, sefer);
            }
        }
        public void DeleteSeferbyID(String seferid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "DELETE FROM Sefer WHERE Sefer='" + seferid + "'";
                connection.Execute(querystr);
            }
        }
        public void UpdateSefer(string seferid, string ucakid, string ucussuresi, DateTime SeferTarihi, string variszamani, string kalkiszamani, String varisyeri, String kalkisyeri)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "UPDATE Sefer SET UcakID='" + ucakid + "', UcusSuresi='" + ucussuresi + "', SeferTarihi='" + SeferTarihi + "', VarisZamani='" + variszamani + "', KalkisZamani='" + kalkiszamani + "', VarisYeri='" + varisyeri + "', KalkisYeri='" + kalkisyeri + "' WHERE SeferID='" + seferid + "'";

                connection.Execute(querystr);
            }
        }




        public void UpdateMurettebat(string murettebatID, string ucakID, string personelID, string yabanciDil, string ucusSuresi, string murettebatTipi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "UPDATE Murettebat SET YabanciDil='" + yabanciDil + "', UcusSuresi='" + ucusSuresi + "', MurettebatTipi='" + murettebatTipi + "' WHERE MurettebatID='" + murettebatID + "'";

                connection.Execute(querystr);

            }
        }

        public void DeleteMurettebat(string murettebatID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "DELETE FROM Murettebat WHERE MurettebatID='" + murettebatID + "'";
                connection.Execute(querystr);

            }
        }

        public void EkleMurettebat(string murettebatID, string ucakID, string personelID, string yabanciDil, string ucusSuresi, string murettebatTipi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string sql = "INSERT INTO Murettebat (MurettebatID, UcakID, PersonelID,YabanciDil, UcusSuresi, MurettebatTipi) Values (@murettebatID, @ucakID , @personelID , @yabanciDil , @ucusSuresi , @murettebatTipi );";

                Murettebat murettebat = new Murettebat { MurettebatID = murettebatID, UcakID = ucakID, PersonelID = personelID, YabanciDil = yabanciDil, UcusSuresi = ucusSuresi, MurettebatTipi = murettebatTipi };
                connection.Execute(sql, murettebat);


            }
        }


    }
}

    

