using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMTesting.Utils
{
    public static class ConnectString
    {
        public static string GetString()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            string DbPath = System.IO.Path.Join(path, "blogging.db");
            return  $"Data Source={DbPath}";
            

        }
        public static string SQLConnectionString() => "Server=(localdb)\\mssqllocaldb;Database=TestDb;Trusted_Connection=True;";
    }
}
