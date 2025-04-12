using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_BL.DTOs.Student;
using CourseSystem_DAL.Models;
using CourseSystem_DAL.Repositories;

namespace CourseSystem_BL.Managers
{

    public class ManagerStudent
    {
        private readonly RepoStudent repo;
        public ManagerStudent()
        {
            repo = new RepoStudent();
        }
        public List<DTOStudent> Get() => repo.Get().Select(s => new DTOStudent()
        {
            FirstName = s.FirstName,
            LastName = s.LastName,
            Id = s.Id,
            Phone = s.Phone,
        }).ToList();
        public DTOStudent GetById(Guid id) {
            var s = repo.GetById(id);
            return new DTOStudent()
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                Id = s.Id,
                Phone = s.Phone,
            };


        } 
        public void Create( DTOStudent newStudent)
        {
            var data = new Student(newStudent.Id,newStudent.FirstName,newStudent.LastName,newStudent.Phone);
            repo.Create(data);
            repo.SaveChanges();
        }
        public void Update(DTOStudent newStudent)
        {
            var data = repo.GetById(newStudent.Id);
            data.FirstName = newStudent.FirstName;
            data.LastName = newStudent.LastName;
            data.Phone = newStudent.Phone;

            repo.SaveChanges();
        }
        public void Delete(Guid id)
        {
            var data = repo.GetById(id);
            repo.Delete(data);
            repo.SaveChanges();
        }
    }
}
