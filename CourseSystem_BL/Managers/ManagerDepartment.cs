using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_BL.DTOs.Department;
using CourseSystem_BL.DTOs.Instructor;
using CourseSystem_DAL;

namespace CourseSystem_BL
{

    public class ManagerDepartment
    {
        private readonly RepoDepartment repo;
        public ManagerDepartment()
        {
            repo = new RepoDepartment();
        }
        public List<DTODepartmentRead> Get() => repo.Get().Select(d => new DTODepartmentRead { Id = d.Id, Location = d.Location, Name = d.Name, Manager = "" }).OrderBy(d => d.Name).ToList();
        public List<DTODepartmentRead> GetDepartmentsWithManager() => repo.GetDepartmentsWithManager().Select(d => new DTODepartmentRead { Id = d.Id, Location = d.Location, Name = d.Name, Manager = $"{d.Manager.FirstName} {d.Manager.LastName}" }).OrderBy(d => d.Name).ToList();
        public DTODepartmentUpdate GetById(Guid id)
        {
            var d = repo.GetById(id);

            var result = new DTODepartmentUpdate { Id = d.Id, Location = d.Location, Name = d.Name, ManagerId = d.ManagerId };
            return result;

        }
        public void Update(DTODepartmentUpdate newDat) {
            var department=repo.GetById(newDat.Id);
            department.Name = newDat.Name;
            department.ManagerId = newDat.ManagerId;
            department.Location = newDat.Location;  
            repo.SaveChanges();
        }
        public void Create(DTODepartmentCreate newData)
        {
            var data = new Department(Guid.NewGuid(), newData.Name, newData.Location, newData.ManagerId);
            if (!repo.IsManager(newData.ManagerId))
            {
                repo.Create(data);
            }
            else throw new Exception();
            repo.SaveChanges();

        }
    }
}
