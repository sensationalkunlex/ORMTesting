using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ORMTesting.Models;
using ORMTesting.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMTesting.Data
{
    public class AppDBContext : DbContext
    {
        private static readonly string _connectionString = ConnectString.SQLConnectionString();
        public DbSet<Product> Products { get; set; }
        

        public string DbPath { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionString);

        }
    }
}
