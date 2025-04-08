using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CourseSystem_DAL
{
    public class Repository<T> where T : class
    {
        protected readonly MyContext _context;
        public Repository()
        {
            _context = new MyContext();
        }
        public async Task<List<T>> GetAsync()=>await _context.Set<T>().ToListAsync();

    }
}
