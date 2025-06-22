using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Data;
using Unicom_TIC_Management_System.Model;

namespace Unicom_TIC_Management_System.Controller
{
    internal class UserController
    {
        public static void Insert(string name, int age)
        {
            using (var conn = DbPath.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO Users (Name, Age) VALUES (@name, @age);";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Data inserted successfully.");
                }
            }
        }
        public static void ReadAll()
        {
            using (var conn = DbPath.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Users;";

                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}");
                    }
                }
            }
        }

        public void AddUser(User user)
        {
            using (var conn = DbPath.GetConnection())
            {
                string sql = @"INSERT INTO Users (Name, Address, DateOfBirth, NIC, Phone, Email, Course, Subjects, Role, Username, Password) " +
                         "VALUES (@Name, @Address, @DateOfBirth, @NIC, @Phone, @Email, @Course, @Subjects, @Role, @Username, @Password);";
                try
                {
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", user.Name);
                        cmd.Parameters.AddWithValue("@Address", user.Address);
                        cmd.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                        cmd.Parameters.AddWithValue("@NIC", user.NIC);
                        cmd.Parameters.AddWithValue("@Phone", user.Phone);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@Course", user.Course);
                        cmd.Parameters.AddWithValue("@Subjects", user.Subjects);
                        cmd.Parameters.AddWithValue("@Role", user.Role);
                        cmd.Parameters.AddWithValue("@Username", user.Name);
                        cmd.Parameters.AddWithValue("@Password", "admin@123");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User data add successfully.");

                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        public List<User> GetUser()
        {
            List<User> getuser = new List<User>();
            try
            {
                using (var conn = DbPath.GetConnection())
                {
                    var cmd = new SQLiteCommand("select Name,Address from Users", conn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        User user = new User
                        {
                            Name = reader.GetString(0),
                            Address = reader.GetString(1),
                        };
                        getuser.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return getuser;
        }
    }
}
