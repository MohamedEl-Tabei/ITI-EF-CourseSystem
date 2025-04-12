using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseSystem_DAL.Repositories
{
    public class RepoCourseSessionAttendance:Repository<CourseSessionAttendance>
    {
        public List<CourseSessionAttendance> GetWithCourseAndInstructor() => _context.CourseSessionAttendances.Include(c => c.CourseSession).Include(c => c.Student).ToList();
    
    
    }
}
