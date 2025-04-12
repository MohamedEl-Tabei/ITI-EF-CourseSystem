using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem_DAL.Models
{
    public class CourseSession
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }

        public DateTime Date { get; set; }
        public string Title { get; set; }
        public List< CourseSessionAttendance> CourseSessionAttendances { get; set; }
        public CourseSession(Guid id,Guid courseId,Guid instructorId,DateTime date,string title) {
            CourseId = courseId;
            InstructorId = instructorId;
            Date = date;
            Title = title;
            Id = id;
        }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}
