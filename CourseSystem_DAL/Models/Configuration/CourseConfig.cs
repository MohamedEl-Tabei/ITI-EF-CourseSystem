using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSystem_DAL.Models.Configuration
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(255);
            builder.HasOne(c=>c.Department).WithMany(d=>d.Courses).HasForeignKey(c=>c.DepartmentId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c=>c.Instructor).WithMany(i=>i.Courses).HasForeignKey(i=>i.InstructorId).OnDelete(DeleteBehavior.Restrict);
            builder.HasData(DemoData.GetDemoCourses());

        }
    }
}
