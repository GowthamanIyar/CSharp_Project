using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Model
{
    internal class Subject
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } // Subject Name
        public int CourseId { get; set; } // Foreign Key to Course
    }
}
