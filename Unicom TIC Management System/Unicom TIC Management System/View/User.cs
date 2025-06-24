using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controller;
using Unicom_TIC_Management_System.Model;

namespace Unicom_TIC_Management_System
{
    
    public partial class user : Form
    {
        private int selectedRole;
        private string userrole;

        public user()
        {
            InitializeComponent();
            loadroles();
            viewuser();
        }

        public void loadroles() 
        {
            List<string> rolelist = new List<string> { "Admin", "Staff", "Lecturer", "Student" };
            roles.DataSource = rolelist;
        }
        public void adduser()
        {
            User user = new User
            {
                Name = names.Text,
                Address = addresses.Text,
                DateOfBirth = dob.Text,
                NIC = nic.Text,
                Phone = Convert.ToInt32(phone.Text),
                Email = email.Text,
                Course = course.Text,
                Subjects = subjects.Text,
                Role = userrole,
            };
            UserController userController = new UserController();
            userController.AddUser(user);

        }


        public void viewuser() 
        {
            UserController getuser = new UserController();
            var userlist = getuser.GetUser();
            data.DataSource = userlist;
            data.Columns["Password"].Visible = false;
            data.Columns["Username"].Visible = false;

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRole = roles.SelectedIndex+1;
            if (selectedRole == 0) { userrole = "Admin"; } else if (selectedRole == 1) { userrole = "Staff"; } else if (selectedRole == 2) { userrole = "Lecturer"; } else if (selectedRole == 3) { userrole = "Student"; };
        }

        private void add_Click(object sender, EventArgs e)
        {
            adduser();
            viewuser();

        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
