using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Controller
{
    internal class CourseController
    {
        // This class will handle course-related operations such as adding, updating, deleting, and retrieving courses.
        // It will interact with the Course model and possibly a database or in-memory data structure.
        public void AddCourse(string courseName, string courseCode)
        {
            // Logic to add a new course
        }
        public void UpdateCourse(int courseId, string newCourseName, string newCourseCode)
        {
            // Logic to update an existing course
        }
        public void DeleteCourse(int courseId)
        {
            // Logic to delete a course
        }
        public List<string> GetAllCourses()
        {
            // Logic to retrieve all courses
            return new List<string>();
        }
    }
}
