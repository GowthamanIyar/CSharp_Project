using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Model
{
    internal class User
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
        public string NIC { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Subjects { get; set; }
        public string Role { get; set; } // Admin, Staff, Lecturer, Student
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; } // Primary Key

    }
}
