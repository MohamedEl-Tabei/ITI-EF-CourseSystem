using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem_DAL.Models
{
    public class Student : Human
    {
        public Student(Guid id, string? firstName, string? lastName, string? phone) : base(id, firstName, lastName, phone) { }
        public List<StudentCourse> CoursesStudent { get; set; }
        public List<CourseSessionAttendance> CourseSessionAttendances { get; set; }
    }
}
