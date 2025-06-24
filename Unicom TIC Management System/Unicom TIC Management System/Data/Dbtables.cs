using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Data
{
    internal class Dbtables
    {
        public static void Dbconn()
        {
            using (var conn = DbPath.GetConnection())
            {    
                string Query = @"CREATE TABLE IF NOT EXISTS Users (
                                UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                                Name TEXT NOT NULL,
                                Address TEXT NOT NULL,
                                DateOfBirth DATE NOT NULL,
                                NIC TEXT,                               
                                Phone INTEGER,
                                Email TEXT,
                                Course TEXT,
                                Subjects TEXT,
                                Role TEXT 
                                Username TEXT NOT NULL ,
                                Password TEXT NOT NULL 
                                );"   ;

                var cmd = new SQLiteCommand(Query, conn); 
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table created successfully.");
            }
        }
    }
}
