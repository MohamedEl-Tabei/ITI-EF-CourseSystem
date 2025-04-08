using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_BL.DTOs.Instructor;
using CourseSystem_DAL;

namespace CourseSystem_BL.Managers
{
    public class ManagerInstructor
    {
        private readonly RepoInstructor repo;
        public ManagerInstructor()
        {
            repo = new RepoInstructor();
        }
        public List<DTOInstructorRead> GetWithDepartment()
        {
            var data =  repo.GetWithDepartment();
            var result = data.Select(r => new DTOInstructorRead
            {
                Department = r.Department?.Name,
                Name = $"{r.FirstName} {r.LastName}",
                Id = r.Id,
                Phone = r.Phone

            }).ToList();

            return result;
        }
    }
}
