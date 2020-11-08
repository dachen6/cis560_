using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Cis560_proj
{
    public class dataAccess
    {
        public List<Customers> Getcus(string lastname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.Cnnval("database")))
            {
                 var output = connection.Query<Customers>($"select * from Proj.customer where Proj.customer.Name = '{lastname}' ").ToList();
                return output;
            }
        }
    }
}
