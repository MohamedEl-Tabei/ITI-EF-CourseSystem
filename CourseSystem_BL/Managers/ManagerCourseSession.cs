using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_BL.DTOs.Course;
using CourseSystem_BL.DTOs.CourseSession;
using CourseSystem_BL.DTOs.CourseSessionAttendance;
using CourseSystem_BL.DTOs.Department;
using CourseSystem_DAL;
using CourseSystem_DAL.Models;
using CourseSystem_DAL.Repositories;

namespace CourseSystem_BL.Managers
{
    public class ManagerCourseSession
    {
        private readonly RepoCourseSession repo;
        public ManagerCourseSession()
        {
            repo = new RepoCourseSession();

        }
        public List<DTOCourseSession> GetDTOCourseSession()
        {
            var data = repo.GetWithCourseAndInstructor();
            var result = data.Select(d => new DTOCourseSession()
            {
                CourseId = d.CourseId,
                CourseName = d.Course.Name,
                Id = d.Id,
                Date = d.Date,
                InstructorId = d.InstructorId,
                InstructorName = d.Instructor.FirstName,
                Title = d.Title
            }).ToList();
            return result;

        }
        public void Create(DTOCourseSession newData)
        {
            var data = new CourseSession(new Guid(), newData.CourseId, newData.InstructorId, newData.Date, newData.Title);
            repo.Create(data);

            repo.SaveChanges();

        }
        public void Update(DTOCourseSession newData)
        {
            var data = repo.GetById(newData.Id);
            data.CourseId = newData.CourseId;
            data.Title = newData.Title;
            data.InstructorId = newData.InstructorId;
            data.Date = newData.Date;
            repo.SaveChanges();

        }
        public DTOCourseSession GetById(Guid id)
        {
            var d = repo.GetById(id);
            var result = new DTOCourseSession()
            {

                CourseId = d.CourseId,
                CourseName = d.Course.Name,
                Id = d.Id,
                Date = d.Date,
                InstructorId = d.InstructorId,
                InstructorName = d.Instructor.FirstName,
                Title = d.Title
            };
            return result;


        }
        public void Delete(Guid id)
        {
            var data = repo.GetById(id);
            repo.Delete(data);
            repo.SaveChanges();
        }
    }
}
