using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_DAL.Models;

namespace CourseSystem_DAL
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }

        #region Department
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
        #endregion
        #region Instructor
        public Guid InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        #endregion
        public List<StudentCourse> StudentCourses { get; set; }
        public List<CourseSession> CourseSessions { get; set; }

        public Course(Guid id,string name,int duration,Guid departmentId,Guid instructorId)
        {
            Id = id;
            Name = name;
            Duration = duration;
            DepartmentId = departmentId;
            InstructorId = instructorId;
        }
       
    }
}
