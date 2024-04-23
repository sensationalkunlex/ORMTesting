﻿using Microsoft.Data.Sqlite;
using ORMTesting.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMTesting.Data
{
    public static  class DBConnection
    {
        private static readonly string _connectionString= ConnectString.GetString();
        public static SqliteConnection GetSqliteConnection() => new SqliteConnection(_connectionString);

        

    }
}
