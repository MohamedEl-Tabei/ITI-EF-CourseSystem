using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem_BL.DTOs.Course
{
    public class DTOCourseUpdate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid InstructorId { get; set; }
    }
}
