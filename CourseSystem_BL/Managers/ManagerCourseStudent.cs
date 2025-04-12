using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_BL.DTOs.CourseStudent;
using CourseSystem_DAL.Models;
using CourseSystem_DAL.Repositories;

namespace CourseSystem_BL.Managers
{
    public class ManagerCourseStudent
    {
        private readonly RepoStudentCourse repo;

        public ManagerCourseStudent()
        {
            repo = new RepoStudentCourse();
        }
        public List<DTOCourseStudent> GetWithStudentAndCourse() {

            var data = repo.GetWithStudentAndCourse();
            var result= data.Select(cs=>new DTOCourseStudent()
            {
                StudentId=cs.StudentId,
                CourseId=cs.CourseId,
                CourseName=cs.Course.Name,
                StudentName=$"{cs.Student.FirstName} {cs.Student.LastName}"
            }).ToList();

            return result;
        }
        public void Create(DTOCourseStudent newStudentCourse) {
            var data = new StudentCourse(newStudentCourse.CourseId, newStudentCourse.StudentId);
            bool isExist = repo.IsExist(data);
            if (!isExist) { 
                repo.Create(data);
                repo.SaveChanges();
            }
            else
            {
                throw new Exception($"{newStudentCourse.StudentName}  is in this {newStudentCourse.CourseName} course");
            }
        
        }
        public void Delete(Guid courseId,string studentName)
        {
            repo.DeleteBycourseIdStudentName(courseId,studentName);
            repo.SaveChanges();
        }


    }
}
