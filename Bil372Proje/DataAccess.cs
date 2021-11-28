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
        public void getPersonelAdi()
        {



        }
        public List<Ucak> GetUcak()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Bil372")))
            {
                var output = connection.Query<Ucak>($"select * from Ucak; ").ToList();
                return output;
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
    }
}
