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
    }
}
