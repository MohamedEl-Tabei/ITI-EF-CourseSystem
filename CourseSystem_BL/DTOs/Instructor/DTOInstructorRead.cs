using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem_BL.DTOs.Instructor
{
    public class DTOInstructorRead
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string Phone {  get; set; }
        public string Department { get; set; }

    }
}
