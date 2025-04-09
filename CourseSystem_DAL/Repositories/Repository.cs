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
        public  List<T> Get()=> _context.Set<T>().ToList();
        public T GetById(Guid id) => _context.Set<T>().Find(id);
        public void Create(T t)=>_context.Set<T>().Add(t);
        public void SaveChanges()=>_context.SaveChanges();

    }
}
