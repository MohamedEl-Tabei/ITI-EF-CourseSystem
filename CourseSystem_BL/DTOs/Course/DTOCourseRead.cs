using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem_BL.DTOs.Course
{
    public class DTOCourseRead
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public string Department { get; set; }
        public string Instructor { get; set; }

    }
}
