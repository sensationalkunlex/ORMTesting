
using Dapper;
using ORMProject.Model;
using ORMTesting.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ORMProject.ORM
{
    public static class DapperQuery
    {
        public static void SelectQueryImplementation(int numberOfRecords=5000)
        {
            var parameter = new { numberOfRecords };
            
            using (IDbConnection connection = DBConnection.GetSqlConnection())
            {
                var products = connection.Query<ProductDTO>
                    ($"Select Top(@numberOfRecords)  * from Products ", parameter)
                    .ToList();
            }
        }
    }
}
