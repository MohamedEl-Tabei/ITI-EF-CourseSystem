using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_BL.DTOs.Course;
using CourseSystem_DAL;

namespace CourseSystem_BL.Managers
{

    public class ManagerCourse
    {
        private readonly RepoCourse repo;
        public ManagerCourse() => repo = new RepoCourse();

        public List<DTOCourseRead> GetWithDepartmentAndInstructor()
        {
            var data = repo.GetWithDepartmentAndInstructor();
            var result = data.Select(c => new DTOCourseRead
            {
                Department = c.Department.Name,

                Name = c.Name,
                Duration = c.Duration,
                Instructor = $"{c.Instructor.FirstName} {c.Instructor.LastName}"

            }).ToList();
            return result;
        }
        public List<DTOCourseRead> GetByDepartment(Guid id)
        {
            var data = repo.GetByDepartment(id);
            var result = data.Select(c => new DTOCourseRead
            {
                Department = c.Department.Name,

                Name = c.Name,
                Duration = c.Duration,
                Instructor = $"{c.Instructor.FirstName} {c.Instructor.LastName}"

            }).ToList();
            return result;


        }
        public List<DTOCourseRead> GetByInstructor(Guid id)
        {
            var data = repo.GetByInstructor(id);
            var result = data.Select(c => new DTOCourseRead
            {
                Department = c.Department.Name,

                Name = c.Name,
                Duration = c.Duration,
                Instructor = $"{c.Instructor.FirstName} {c.Instructor.LastName}"

            }).ToList();
            return result;


        }
        public void Create(DTOCourseCreate newData)
        {
            var data = new Course(Guid.NewGuid(), newData.Name, newData.Duration, newData.DepartmentId, newData.InstructorId);
            repo.Create(data);
            repo.SaveChanges();
        }
        public void Update(DTOCourseUpdate newData)
        {
            var data = repo.GetById(newData.Id);
            data.Duration = newData.Duration;
            data.InstructorId = newData.InstructorId;
            data.DepartmentId = newData.DepartmentId;
            data.Name = newData.Name;
            repo.SaveChanges();
        }
        public List<DTOCourseUpdate> Get()
        {
            var data = repo.Get();
            var result = data.Select(c => new DTOCourseUpdate
            {
                DepartmentId = c.DepartmentId,
                Id=c.Id,
                Name = c.Name,
                Duration = c.Duration,
                InstructorId = c.InstructorId

            }).ToList();
            return result;


        }
        public DTOCourseUpdate GetById(Guid id)
        {
            var data = repo.GetById(id);
            var result = new DTOCourseUpdate()
            {
                DepartmentId = data.DepartmentId,
                Id=data.Id,
                Name = data.Name,
                Duration = data.Duration,
                InstructorId = data.InstructorId

            };
            return result;


        }
    }
}
