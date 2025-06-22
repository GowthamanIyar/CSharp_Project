using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Data
{
    internal class DbPath
    {
        private const string ConnectionString = "Data Source=MyDatabase.db;Version=3;";
       
        public static SQLiteConnection GetConnection()
        {
            var Connection = new SQLiteConnection(ConnectionString);
            Connection.Open();
            return Connection;
        }

        
    }
}
