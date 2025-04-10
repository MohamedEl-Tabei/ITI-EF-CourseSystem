using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_DAL.Models;

namespace CourseSystem_DAL
{
    public class Department
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        #region Manager
        public Instructor? Manager { get; set; }
        public Guid ManagerId { get; set; }
        #endregion

        public Department(Guid id,string name,string location,Guid managerId)
        {
            Id = id;
            Name = name;
            Location = location;
            ManagerId = managerId;
        }


        public List<Instructor>? Instructors { get; set; }
        public List<Course>? Courses { get; set; }
    }
}
