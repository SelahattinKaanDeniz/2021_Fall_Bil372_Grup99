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
                var output = connection.Query<Personel>($"select * from Personel where not exists(select Murettebat.PersonelID from Murettebat where Murettebat.PersonelID=Personel.PersonelID ) and not exists(select ServisPersoneli.PersonelID from ServisPersoneli where ServisPersoneli.PersonelID=Personel.PersonelID) and PersonelTipi = 'Servis'").ToList();
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

        public List<ServisPersoneli> getServisPersoneliAtanmisAdi()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<ServisPersoneli>($"select Ad, Soyad,Personel.PersonelID,TamirPersoneli.Uzmanlik from Personel,TamirPersoneli where Personel.PersonelID=TamirPersoneli.PersonelID").ToList();
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

        //public void UpdateUcak(string ucakID, string model, string yolcukapasitesi, string agirlik, string ureticifirma, string uretimyili)

        public List<Personel> GetPersonel()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Personel>($"select * from Personel; ").ToList();
                return output;
            }
        }
        public List<TamirPersoneli> GetTamirPersoneli()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<TamirPersoneli>($"select * from TamirPersoneli  ").ToList();
                return output;
            }
        }

        public List<GenelBakimTeknisyeni> GetGenelBakimTeknisyeni()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<GenelBakimTeknisyeni>($"select * from GenelBakimTeknisyeni  ").ToList();
                return output;
            }
        }
        public List<ServisPersoneli> GetServisPersoneli()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<ServisPersoneli>($"select * from ServisPersoneli  ").ToList();
                return output;
            }
        }

        public String GetServisPersoneliAdi(string ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Personel>($"select Ad,Soyad from Personel where PersonelID='{ID}' ").ToList();
                return output[0].Ad+" "+ output[0].Soyad;
            }
        }
        public String getServisPersoneliIDbyName(string Ad, string Soyad)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Personel>($"select PersonelID from Personel where Personel.Ad='{Ad}' and Personel.Soyad='{Soyad}' ").ToList();
                 
                return output[0].PersonelID;
            }


        }


        public void UpdateUcak(string ucakID,string model, string yolcukapasitesi, string agirlik, string ureticifirma, string uretimyili)

        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "UPDATE Ucak SET Model='" + model + "', Yolcukapasitesi='" + yolcukapasitesi + "', Agirlik='" + agirlik + "', UreticiFirma='" + ureticifirma + "', UretimYili='" + uretimyili + "' WHERE UcakID='" + ucakID + "'";

                connection.Execute(querystr);

            }
        }

        public void UpdateServisPersoneli(string ServisPersoneliID, string ServisPersoneliTipi, string PersonelID, string CalistigiHavalimani)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "UPDATE ServisPersoneli SET  ServisPersonelTipi='" + ServisPersoneliTipi + "', ServisPersoneliID='" + ServisPersoneliID + "', CalistigiHavalimani='" + CalistigiHavalimani+ "' WHERE PersonelID='" + PersonelID + "'";

                connection.Execute(querystr);

            }
        }
        public void UpdateTamirPersoneli(string ServisPersoneliID, string PersonelID, string Uzmanlik)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "UPDATE TamirPersoneli SET   ServisPersoneliID='" + ServisPersoneliID + "', Uzmanlik='" + Uzmanlik + "' WHERE PersonelID='" + PersonelID + "'";

                connection.Execute(querystr);

            }
        }

        public void UpdateGenelBakimTeknisyeni(string ServisPersoneliID, string PersonelID, string TeknisyenDerecesi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "UPDATE GenelBakimTeknisyeni SET   ServisPersoneliID='" + ServisPersoneliID + "', TeknisyenDerecesi='" + TeknisyenDerecesi + "' WHERE PersonelID='" + PersonelID + "'";

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

        public void EkleServisPersoneli(string ServisPersoneliID, string ServisPersonelTipi, string PersonelID, string CalistigiHavalimani)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string sql = "INSERT INTO ServisPersoneli  Values (@ServisPersoneliID, @ServisPersonelTipi , @PersonelID , @CalistigiHavalimani );";

                ServisPersoneli sp = new ServisPersoneli { ServisPersoneliID = ServisPersoneliID, ServisPersonelTipi = ServisPersonelTipi, PersonelID = PersonelID, CalistigiHavalimani = CalistigiHavalimani };
                connection.Execute(sql, sp);
                
            }
        }
        public void EkleTamirPersoneli(string ServisPersoneliID, string PersonelID, string Uzmanlik)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string sql = "INSERT INTO TamirPersoneli  Values (@ServisPersoneliID, @PersonelID , @Uzmanlik );";

                TamirPersoneli sp = new TamirPersoneli { ServisPersoneliID = ServisPersoneliID, PersonelID = PersonelID, Uzmanlik = Uzmanlik };
                connection.Execute(sql, sp);

            }
        }

        public void EkleGenelBakimTeknisyeni(string ServisPersoneliID, string PersonelID, string TeknisyenDerecesi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string sql = "INSERT INTO GenelBakimTeknisyeni  Values (@ServisPersoneliID, @PersonelID , @TeknisyenDerecesi );";

                GenelBakimTeknisyeni sp = new GenelBakimTeknisyeni { ServisPersoneliID = ServisPersoneliID, PersonelID = PersonelID, TeknisyenDerecesi = TeknisyenDerecesi };
                connection.Execute(sql, sp);

            }
        }
        public void DeleteServisPersoneli(string ServisPersoneliID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "DELETE FROM ServisPersoneli WHERE ServisPersoneliID='" + ServisPersoneliID + "'";
                connection.Execute(querystr);


            }
        }

        public void DeleteTamirPersoneli(string ServisPersoneliID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "DELETE FROM TamirPersoneli WHERE ServisPersoneliID='" + ServisPersoneliID + "'";
                connection.Execute(querystr);


            }
        }

        public void DeleteGenelBakimTeknisyeni(string ServisPersoneliID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "DELETE FROM GenelBakimTeknisyeni WHERE ServisPersoneliID='" + ServisPersoneliID + "'";
                connection.Execute(querystr);


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

        public String getGenelBakimTeknisyeniIDbyName(string Ad, string Soyad)
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

        public List<Personel> getAtanmamisServisPersoneliAdiTamirPersoneli()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Personel>($" select  * from personel where Personel.PersonelID IN(select  ServisPersoneli.PersonelID from ServisPersoneli where not exists(select TamirPersoneli.PersonelID from TamirPersoneli where TamirPersoneli.PersonelID = ServisPersoneli.PersonelID) and not exists(select GenelBakimTeknisyeni.PersonelID from GenelBakimTeknisyeni where GenelBakimTeknisyeni.PersonelID = ServisPersoneli.PersonelID) and ServisPersonelTipi = 'Tamir')").ToList();
                return output;
            }
        }
        public List<Personel> getAtanmamisServisPersoneliAdiGenelBakimTeknisyeni()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Personel>($" select  * from personel where Personel.PersonelID IN(select  ServisPersoneli.PersonelID from ServisPersoneli where not exists(select TamirPersoneli.PersonelID from TamirPersoneli where TamirPersoneli.PersonelID = ServisPersoneli.PersonelID) and not exists(select GenelBakimTeknisyeni.PersonelID from GenelBakimTeknisyeni where GenelBakimTeknisyeni.PersonelID = ServisPersoneli.PersonelID) and ServisPersonelTipi = 'Bakim')").ToList();
                return output;
            }
        }

        public string getServisPersonelIDbyPersonelID(string PersonelID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<ServisPersoneli>($" select  * from ServisPersoneli where ServisPersoneli.PersonelID='{PersonelID}'").ToList();
                return output[0].ServisPersoneliID;
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


        public List<Personel> getServisPersoneli()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Personel>($"select Ad, Soyad from Personel where PersonelTipi='Servis'").ToList();
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
        public List<Servis> GetServis()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Servis>($"SELECT * FROM Servis").ToList();
                return output;
            }
        }
        public void InsertServis(String servisid,String ucakid,DateTime baslangictarihi,DateTime bitistarihi,String servistipi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                Servis servis = new Servis();
                servis.ServisID = servisid;
                servis.UcakID = ucakid;
                servis.BaslangicTarihi = baslangictarihi;
                servis.BitisTarihi = bitistarihi;
                servis.ServisTipi = servistipi;
                string sql = "INSERT INTO Servis (ServisID,UcakID,BaslangicTarihi,BitisTarihi,ServisTipi) Values (@ServisID,@UcakID,@BaslangicTarihi,@BitisTarihi,@ServisTipi);";
                connection.Execute(sql, servis);
            }
        }
        public void UpdateServis(string servisid, string ucakID, DateTime baslangictarihi, DateTime bitistarihi, string servistipi)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "UPDATE Servis SET UcakID='" + ucakID + "', BaslangicTarihi='" + baslangictarihi + "', BitisTarihi='" + bitistarihi + "', ServisTipi='" + servistipi + "' WHERE ServisID='" + servisid + "'";

                connection.Execute(querystr);

            }
        }
        public void DeleteServis(string ServisID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "DELETE FROM Servis WHERE ServisID='" + ServisID + "'";
                connection.Execute(querystr);

            }
        }
        public List<Tamir> GetTamir()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Tamir>($"select * from Tamir; ").ToList();
                return output;
            }
        }
        public void DeleteTamir(string servisid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "DELETE FROM Tamir WHERE ServisID='" + servisid + "'";
                connection.Execute(querystr);

            }
        }
        public void UpdateTamir(string servisid, DateTime kazatarihi, string kazasebebi,string tamirsonucu)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "UPDATE Tamir SET KazaTarihi='" + kazatarihi + "', KazaSebebi='" + kazasebebi + "', TamirSonucu='" + tamirsonucu + "' WHERE ServisID='" + servisid + "'";

                connection.Execute(querystr);

            }
        }
        public void InsertTamir(String servisid, String ucakid, String personelid, DateTime kazatarihi, String kazasebebi,string tamirsonucu)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                Tamir tamir = new Tamir();
                tamir.ServisID = servisid;
                tamir.UcakID = ucakid;
                tamir.PersonelID = personelid;
                tamir.KazaTarihi = kazatarihi;
                tamir.KazaSebebi = kazasebebi;
                tamir.TamirSonucu = tamirsonucu;
  
                string sql = "INSERT INTO Tamir (PersonelID,ServisID,UcakID,KazaTarihi,KazaSebebi,TamirSonucu) Values (@PersonelID,@ServisID,@UcakID,@KazaTarihi,@KazaSebebi,@TamirSonucu);";
                connection.Execute(sql, tamir);
            }
        }
        public void InsertGenelBakim (String servisid, String ucakid, String personelid, String bakimturu)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                GenelBakim bakim = new GenelBakim();
                bakim.PersonelID = personelid;
                bakim.UcakID = ucakid;
                bakim.ServisID = servisid;
                bakim.BakimTuru = bakimturu;
                

                string sql = "INSERT INTO GenelBakim (PersonelID,ServisID,UcakID,BakimTuru) Values (@PersonelID,@ServisID,@UcakID,@BakimTuru);";
                connection.Execute(sql, bakim);
            }
        }
        public void UpdateGenelBakim(String servisid, String bakimturu)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "UPDATE GenelBakim SET BakimTuru='" + bakimturu + "' WHERE ServisID='" + servisid + "'";

                connection.Execute(querystr);

            }
        }
        public void DeleteGenelBakim(string servisid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                string querystr = "DELETE FROM GenelBakim WHERE ServisID='" + servisid + "'";
                connection.Execute(querystr);

            }
        }
        public List<GenelBakim> GetGenelBakim()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<GenelBakim>($"select * from GenelBakim; ").ToList();
                return output;
            }
        }
    }
}

    

