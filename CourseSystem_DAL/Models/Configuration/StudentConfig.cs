using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSystem_DAL.Models.Configuration
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s=>s.FirstName).IsRequired().HasMaxLength(255);
            builder.Property(s=>s.LastName).IsRequired().HasMaxLength(255);
            builder.Property(s=>s.Phone).IsRequired().HasMaxLength(11);
            builder.HasData(DemoData.GetDemoStudents());
        }
    }
}
