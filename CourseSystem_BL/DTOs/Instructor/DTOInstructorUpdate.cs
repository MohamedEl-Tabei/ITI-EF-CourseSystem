using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem_BL.DTOs
{
    public class DTOInstructorUpdate
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public Guid Id { get; set; }
        public Guid? DepartmentId { get; set; }
    }
}
