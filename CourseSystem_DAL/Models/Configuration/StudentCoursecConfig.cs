using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSystem_DAL.Models.Configuration
{
    public class StudentCoursecConfig : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(s => new {s.CourseId, s.StudentId});
            builder.HasOne(s => s.Student).WithMany(s => s.CoursesStudent);
            builder.HasOne(s => s.Course).WithMany(s => s.StudentCourses);
            builder.HasData(DemoData.GetDemoStudentCourse());
        }
    }
}
