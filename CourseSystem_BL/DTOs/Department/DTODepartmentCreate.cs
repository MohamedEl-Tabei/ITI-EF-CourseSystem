﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem_BL.DTOs.Department
{
    public class DTODepartmentCreate
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
        public Guid ManagerId { get; set; }
    }
}
