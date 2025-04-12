using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem_BL.DTOs.CourseStudent
{
    public class DTOCourseStudent
    {
       public Guid StudentId { get; set; }
       public Guid CourseId { get; set; }
        public string StudentName { get; set; }
        public string CourseName { get; set; }
    }
}
