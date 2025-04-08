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
       
        public List<Instructor> GetWithDepartment()=> _context.Set<Instructor>().Include(i=>i.Department).ToList();

    }
}
