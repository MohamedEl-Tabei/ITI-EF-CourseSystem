using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem_BL.DTOs.CourseSessionAttendance
{
    public class DTOCourseSessionAttendance
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid CourseSessionId { get; set; }
        public string CourseSessionName {  get; set; }
        public string StudentName { get; set; }
        public int Grade { get; set; }
        public string Notes { get; set; }
    }
}
