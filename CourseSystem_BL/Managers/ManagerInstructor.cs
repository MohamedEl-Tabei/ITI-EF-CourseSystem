using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_BL.DTOs;
using CourseSystem_BL.DTOs.Instructor;
using CourseSystem_DAL;

namespace CourseSystem_BL.Managers
{
    public class ManagerInstructor
    {
        private readonly RepoInstructor repo;
        private readonly RepoCourse repoCourse;
        public ManagerInstructor()
        {
            repo = new RepoInstructor();
            repoCourse = new RepoCourse();
        }
        public List<DTOInstructorRead> GetWithDepartment()
        {
            var data = repo.GetWithDepartment();
            var result = data.Select(r => new DTOInstructorRead
            {
                Department = r.Department?.Name,
                Name = $"{r.FirstName} {r.LastName}",
                Id = r.Id,
                Phone = r.Phone

            }).ToList();

            return result;
        }
        public DTOInstructorUpdate GetById(Guid id)
        {
            var data = repo.GetById(id);
            var result = new DTOInstructorUpdate
            {
                Id = id,
                DepartmentId = data.DepartmentId,
                FirstName = data.FirstName,
                LastName = data.LastName,
                Phone = data.Phone
            };

            return result;
        }
        public void Update(DTOInstructorUpdate newData)
        {
            var data = repo.GetById(newData.Id);
            data.LastName = newData.LastName;
            data.FirstName = newData.FirstName;
            data.DepartmentId = newData.DepartmentId;
            data.Phone = newData.Phone;

            repo.SaveChanges();

        }
        public void Create(DTOInstructorCreate newData)
        {
            var data = new Instructor(Guid.NewGuid(), newData.DepartmentId, newData.FirstName, newData.LastName, newData.Phone);
            if (GetByPhone(newData.Phone) == null)
            {
                repo.Create(data);
            }
            else throw new Exception();
            repo.SaveChanges();

        }
        public DTOInstructorRead? GetByPhone(string phone)
        {
            var data = repo.GetByPhone(phone);
            if (data is null) return null;
            var result = new DTOInstructorRead()
            {
                Department = data.Department?.Name,
                Name = $"{data.FirstName} {data.LastName}",
                Id = data.Id,
                Phone = data.Phone

            };

            return result;
        }
        public List<DTOInstructorRead> GetByDepartment(Guid id)
        {
            var data = repo.GetByDepartment(id);
            var result = data.Select(r => new DTOInstructorRead
            {
                Department = r.Department?.Name,
                Name = $"{r.FirstName} {r.LastName}",
                Id = r.Id,
                Phone = r.Phone

            }).ToList();

            return result;
        }
        public void Delete(Guid id)
        {
            var data = repo.GetById(id);
            repoCourse.DeleteByInsstructor(id);
            repoCourse.SaveChanges();
            repo.Delete(data);
            repo.SaveChanges();
        }
        public List<DTOInstructorPhone> InstructorsPhone() => repo.Get().Select(i => new DTOInstructorPhone() { Phone = i.Phone, Id = i.Id, Name = $"{i.FirstName} {i.LastName}" }).OrderBy(p => p.Name).ToList();
    }
}
