using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_BL.DTOs.CourseSession;
using CourseSystem_BL.DTOs.CourseSessionAttendance;
using CourseSystem_DAL.Models;
using CourseSystem_DAL.Repositories;

namespace CourseSystem_BL.Managers
{
    public class ManagerCourseSessionAttendance
    {
        private readonly RepoCourseSessionAttendance repo;
        public ManagerCourseSessionAttendance()
        {
            repo = new RepoCourseSessionAttendance();

        }
        public List<DTOCourseSessionAttendance> GetDTOCourseSessionAttendances()
        {
            var data = repo.GetWithCourseAndInstructor();
            var result = data.Select(d => new DTOCourseSessionAttendance()
            {
                CourseSessionId = d.CourseSessionId,
                CourseSessionName = d.CourseSession.Title,
                Grade = d.Grade,
                Id = d.Id,
                Notes = d.Notes,
                StudentId = d.StudentId,
                StudentName = d.Student.FirstName

            }).ToList();
            return result;

        }
        public void Create(DTOCourseSessionAttendance newData)
        {
            var data = new CourseSessionAttendance(new Guid(), newData.CourseSessionId, newData.StudentId, newData.Grade, newData.Notes);
            repo.Create(data);
            repo.SaveChanges();

        }
        public void Update(DTOCourseSessionAttendance newData)
        {
            var data = repo.GetById(newData.Id);
            data.CourseSessionId = newData.CourseSessionId;
            data.StudentId = newData.StudentId;
            data.Grade = newData.Grade;
            data.Notes = newData.Notes;
            repo.SaveChanges();

        }
        public DTOCourseSessionAttendance GetById(Guid id)
        {
            var d = repo.GetById(id);
            var result = new DTOCourseSessionAttendance()
            {
                CourseSessionId = d.CourseSessionId,
                CourseSessionName = d.CourseSession.Title,
                Grade = d.Grade,
                Id = d.Id,
                Notes = d.Notes,
                StudentId = d.StudentId,
                StudentName = d.Student.FirstName
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
