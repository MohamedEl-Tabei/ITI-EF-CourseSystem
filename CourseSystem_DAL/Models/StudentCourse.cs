using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem_DAL.Models
{
    public class StudentCourse
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
        public StudentCourse(Guid courseId,Guid studentId) { 
            StudentId=studentId;
            CourseId=courseId;
        }
    }
}
