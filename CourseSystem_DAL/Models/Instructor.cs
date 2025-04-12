using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_DAL.Models;

namespace CourseSystem_DAL
{
    public class Instructor : Human
    {
        public Department? Department { get; set; }
        public Guid? DepartmentId { get; set; }
        public Department? ManagedDepartment { get; set; }
        public Instructor(Guid id,Guid? departmentId, string? firstName, string? lastName, string? phone) : base(id,firstName, lastName, phone)
        {
            DepartmentId = departmentId;
        }
        public List<Course>? Courses { get; set; }
        public List<CourseSession> CourseSessions { get; set; }
    }
}
