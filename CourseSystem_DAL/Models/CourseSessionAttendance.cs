using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem_DAL.Models
{
    public class CourseSessionAttendance
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid CourseSessionId { get; set; }

        public int Grade { get; set; }
        public string Notes { get; set; }
        public CourseSessionAttendance(Guid id, Guid courseSessionId, Guid studentId, int grade, string notes)
        {
            Id = id;
            StudentId = studentId;
            CourseSessionId = courseSessionId;
            Grade = grade;
            Notes = notes;
        }
        public Student Student { get; set; }
        public CourseSession CourseSession { get; set; }
    }
}
