using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSystem_DAL
{
    public class DemoData
    {
        public static List<Instructor> GetDemoInstructors() => new List<Instructor>()
        {

            new (new Guid("0e65f178-8ad3-442b-859f-48d6d964b044"), null, "Mohamed", "Ziad", "01120210123" ),
            new (new Guid("30a2d33f-c405-4b72-a7ad-b21e630ada5e"), null, "Basem", "Ahmed", "01020210541" ),
            new (new Guid("8c8e5e8e-2210-4c96-9a78-51f66471627b"), null, "Ahmed", "Omer", "01020210789" ),
            new (new Guid("a7405fe2-f9ff-488c-937b-ff60e3e9c24d"), null, "Amr", "Mohamed", "01520210246" ),
            new (new Guid("b6e66f14-8e6d-4c03-9c12-753ed9e4f74d"), null, "Ali", "Basem", "01220210456" ),
            new (new Guid("c8b09a7f-0c3a-4a97-b586-55f23cfed9a6"), null, "Omer", "Ali", "01220210897" ),
            new (new Guid("e44c2c5d-9de9-45b4-814a-03169fc4edd1"), null, "Ziad", "Amr", "01120210827" )
        };
        public static List<Department> GetDemoDepartments() => new List<Department>()
        {

            new (new Guid("045e90a9-bd08-45ae-80c7-fa8ee939fd74"),"SD",null,new Guid("0e65f178-8ad3-442b-859f-48d6d964b044") ),
            new (new Guid("c11ea3d8-7da5-44bd-a313-e1a6fbafad79"),"UI",null,new Guid("30a2d33f-c405-4b72-a7ad-b21e630ada5e")),
            new (new Guid("cb84409a-44b6-49fa-8a67-92ae33862119"),"Network",null,new Guid("8c8e5e8e-2210-4c96-9a78-51f66471627b")),
            new ( new Guid("d5b7c05f-4fbf-44c3-b181-2176aa8ea9e2"),"Mobile",null,new Guid("a7405fe2-f9ff-488c-937b-ff60e3e9c24d")),
            new (new Guid("d67ae4ea-6fb4-4dbd-af73-90192db76b5a"),"Cloud",null,new Guid("b6e66f14-8e6d-4c03-9c12-753ed9e4f74d") ),
        };
    }
}
