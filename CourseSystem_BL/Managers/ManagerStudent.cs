using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_BL.DTOs.Student;
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

    }
}
