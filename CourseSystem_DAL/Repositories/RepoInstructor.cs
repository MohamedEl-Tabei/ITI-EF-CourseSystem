using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CourseSystem_DAL
{
    public class RepoInstructor:Repository<Instructor>
    {
       
        public List<Instructor> GetWithDepartment()=> _context.Set<Instructor>().Include(i=>i.Department).OrderBy(i => i.FirstName).ToList();
        public List<Instructor> GetByDepartment(Guid departmentId)=> _context.Set<Instructor>().Where(i=>i.DepartmentId==departmentId).Include(i=>i.Department).OrderBy(i => i.FirstName).ToList();
        public Instructor GetByPhone(string phone) => _context.Set<Instructor>().Include(i => i.Department).FirstOrDefault(i=>i.Phone==phone);

    }
}
