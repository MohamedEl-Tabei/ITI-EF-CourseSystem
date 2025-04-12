using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseSystem_DAL.Repositories
{
    public class RepoStudentCourse : Repository<StudentCourse>
    {
        public List<StudentCourse> GetWithStudentAndCourse()
        {
            return _context.StudentCourses.Include(x => x.Course).Include(x => x.Student).ToList();
        }
        public void DeleteBycourseIdStudentName(Guid courseId, string studentName)
        {
            var arr = studentName.Split(" ");
            var data = _context.StudentCourses.Include(x => x.Student).FirstOrDefault(x => x.Student.FirstName == arr[0] && x.Student.LastName == arr[1] && x.CourseId == courseId);
            _context.StudentCourses.Remove(data);

        }
        public void DeleteByCourse(Guid id)
        {
            var courses = _context.StudentCourses.Where(c => c.CourseId == id).ToList();
            _context.StudentCourses.RemoveRange(courses);
        }
        public bool IsExist(StudentCourse studentCourse) => _context.StudentCourses.FirstOrDefault(s => s.CourseId == studentCourse.CourseId && s.StudentId == studentCourse.StudentId) != null;
    }
}
