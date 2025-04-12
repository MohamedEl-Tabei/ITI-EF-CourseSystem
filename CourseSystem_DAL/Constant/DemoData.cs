using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseSystem_DAL.Models;

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
        public static List<Course> GetDemoCourses() => new List<Course>()
        {

            new ( new Guid("1e33dd1b-3a4d-48f5-84c1-565170287dbf"),"C#",4,new Guid("045e90a9-bd08-45ae-80c7-fa8ee939fd74"),new Guid("0e65f178-8ad3-442b-859f-48d6d964b044") ),
            new (new Guid("2ce2280b-8172-4045-8bdc-270794694177"),"Java 0Script",5,new Guid("c11ea3d8-7da5-44bd-a313-e1a6fbafad79"),new Guid("30a2d33f-c405-4b72-a7ad-b21e630ada5e")),
            new (new Guid("5ef659b6-d082-41d0-8f5d-984d883a3482"),"Secuirety",6,new Guid("cb84409a-44b6-49fa-8a67-92ae33862119"),new Guid("8c8e5e8e-2210-4c96-9a78-51f66471627b")),
            new ( new Guid("f78d5fdf-66b7-44be-b9f2-1e42be682a74") ,"Flutter",7,new Guid("d5b7c05f-4fbf-44c3-b181-2176aa8ea9e2"),new Guid("a7405fe2-f9ff-488c-937b-ff60e3e9c24d")),
            new (new Guid("fe17271a-1f45-4a17-b661-30fc9b377f98"),"Azure",8,new Guid("d67ae4ea-6fb4-4dbd-af73-90192db76b5a"),new Guid("b6e66f14-8e6d-4c03-9c12-753ed9e4f74d") ),
        };
        public static List<Student> GetDemoStudents() => new List<Student>()
        {

            new (new Guid("3670be78-8f4d-4bbe-b612-3f628e497896"), "Mohamed", "Ziad", "01120210123" ),
            new (new Guid("67fd4e60-40f4-4842-97fa-8c331f862dcf"),  "Basem", "Ahmed", "01020210541" ),
            new ( new Guid("7cadd23b-7b0a-4dab-9d32-9c2c1570caa4"),  "Ahmed", "Omer", "01020210789" ),
            new ( new Guid("d69770e1-71a0-4ed8-b2eb-cc54fa78e46c"),  "Amr", "Mohamed", "01520210246" ),
            new (new Guid("eef11cbc-ef8c-4224-bc4a-e735412d10ea"),  "Ali", "Basem", "01220210456" ),
            new (new Guid("f1543e8b-4418-4ca8-9d17-223e3eaf7eee"),  "Omer", "Ali", "01220210897" ),
            new (new Guid("f7409cb7-c20d-4f2d-a69a-e695378e8ffc"),  "Ziad", "Amr", "01120210827" )
        };
        public static List<StudentCourse> GetDemoStudentCourse() => new List<StudentCourse>()
        {

            new ( new Guid("1e33dd1b-3a4d-48f5-84c1-565170287dbf"),new Guid("3670be78-8f4d-4bbe-b612-3f628e497896")),
            new ( new Guid("1e33dd1b-3a4d-48f5-84c1-565170287dbf"),new Guid("67fd4e60-40f4-4842-97fa-8c331f862dcf")),

             new ( new Guid("2ce2280b-8172-4045-8bdc-270794694177"),new Guid("3670be78-8f4d-4bbe-b612-3f628e497896")),
            new ( new Guid("2ce2280b-8172-4045-8bdc-270794694177"),new Guid("67fd4e60-40f4-4842-97fa-8c331f862dcf")),


            new ( new Guid("5ef659b6-d082-41d0-8f5d-984d883a3482"),new Guid("3670be78-8f4d-4bbe-b612-3f628e497896")),
            new ( new Guid("5ef659b6-d082-41d0-8f5d-984d883a3482"),new Guid("67fd4e60-40f4-4842-97fa-8c331f862dcf")),
        };

        public static List<CourseSession> GetDemoCourseSession()
        {
            DateTime date = new DateTime(2025, 01, 01);
            return new List<CourseSession>()
            {
                new (new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a17") ,new Guid("1e33dd1b-3a4d-48f5-84c1-565170287dbf"),new Guid("0e65f178-8ad3-442b-859f-48d6d964b044"),date,"title1"),
                new (new Guid("30308204-257c-43a3-b0a8-c18229693a15") ,new Guid("1e33dd1b-3a4d-48f5-84c1-565170287dbf"),new Guid("0e65f178-8ad3-442b-859f-48d6d964b044"),date,"title2"),

                 new (new Guid("739444d1-a7c9-4842-a421-7f6e4aa00050"), new Guid("2ce2280b-8172-4045-8bdc-270794694177"),new Guid("30a2d33f-c405-4b72-a7ad-b21e630ada5e"),date,"title3"),
                new (new Guid("a0054941-4cfc-4e01-a786-0b6eba49e257") ,new Guid("2ce2280b-8172-4045-8bdc-270794694177"),new Guid("30a2d33f-c405-4b72-a7ad-b21e630ada5e"),date,"title4"),


                new (new Guid("ef7d718d-c2ea-4a19-b7d8-c2a2469b0598") ,new Guid("5ef659b6-d082-41d0-8f5d-984d883a3482"),new Guid("b6e66f14-8e6d-4c03-9c12-753ed9e4f74d"),date,"title5"),
                new (new Guid("efe3251e-c1de-4fe1-89f1-be9000a3be78") ,new Guid("5ef659b6-d082-41d0-8f5d-984d883a3482"),new Guid("b6e66f14-8e6d-4c03-9c12-753ed9e4f74d"),date,"title6"),
            };
        }
        public static List<CourseSessionAttendance> GetDemoCourseSessionAttendance()
        {
            return new List<CourseSessionAttendance>()
            {
                new (new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a11") ,new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a17"),new Guid("3670be78-8f4d-4bbe-b612-3f628e497896"),33,"note1"),
                new (new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a12") ,new Guid("30308204-257c-43a3-b0a8-c18229693a15"),new Guid("3670be78-8f4d-4bbe-b612-3f628e497896"),44,"note2"),

                 new (new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a13"), new Guid("739444d1-a7c9-4842-a421-7f6e4aa00050"),new Guid("3670be78-8f4d-4bbe-b612-3f628e497896"),55,"note3"),
                new (new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a14") ,new Guid("a0054941-4cfc-4e01-a786-0b6eba49e257"),new Guid("3670be78-8f4d-4bbe-b612-3f628e497896"),66,"note4"),


                new (new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a15") ,new Guid("ef7d718d-c2ea-4a19-b7d8-c2a2469b0598"),new Guid("3670be78-8f4d-4bbe-b612-3f628e497896"),77,"note5"),
                new (new Guid("217c3d9a-dda7-40ea-b9a2-a0d980c97a16") ,new Guid("efe3251e-c1de-4fe1-89f1-be9000a3be78"),new Guid("3670be78-8f4d-4bbe-b612-3f628e497896"),88,"note6"),
            };
        }
    }
}
