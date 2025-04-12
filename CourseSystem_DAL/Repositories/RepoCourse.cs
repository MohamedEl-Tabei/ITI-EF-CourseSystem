using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CourseSystem_DAL
{
    public class RepoCourse : Repository<Course>
    {
        public List<Course> GetWithDepartmentAndInstructor() => _context.Courses.Include(c => c.Department).Include(c => c.Instructor).ToList();
        public List<Course> GetByDepartment(Guid id) => _context.Courses.Where(c => c.DepartmentId == id).Include(c => c.Department).Include(c => c.Instructor).ToList();
        public List<Course> GetByInstructor(Guid id) => _context.Courses.Where(c => c.InstructorId == id).Include(c => c.Department).Include(c => c.Instructor).ToList();

        public void DeleteByDepartment(Guid departmentId)
        {
            var courses = _context.Courses.Where(c => c.DepartmentId == departmentId).ToList();
            _context.Courses.RemoveRange(courses);
        }
        public void DeleteByInsstructor(Guid InstructorId)
        {
            var courses = _context.Courses.Where(c => c.InstructorId == InstructorId).ToList();
            _context.Courses.RemoveRange(courses);
        }
    }
}
