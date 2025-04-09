using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CourseSystem_DAL
{
    public class RepoDepartment : Repository<Department>
    {
      public List<Department> GetDepartmentsWithManager() =>_context.Departments.Include(d=>d.Manager).OrderBy(d=>d.Name).ToList();
    }
}
