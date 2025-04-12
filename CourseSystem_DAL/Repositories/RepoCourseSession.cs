using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseSystem_DAL.Repositories
{
    public class RepoCourseSession : Repository<CourseSession>
    {
        public List<CourseSession> GetWithCourseAndInstructor() => _context.CourseSessions.Include(c => c.Course).Include(c => c.Instructor).ToList();
        public void DeleteByCourse(Guid id)
        {
            var courses = _context.CourseSessions.Where(c => c.CourseId == id).ToList();
            _context.CourseSessions.RemoveRange(courses);
        }
    }
}
