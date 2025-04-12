using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem_BL.DTOs.CourseSession
{
    public class DTOCourseSession
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
    }
}
