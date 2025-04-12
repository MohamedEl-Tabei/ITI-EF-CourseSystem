using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSystem_DAL.Models.Configuration
{
    public class CourseSessionConfig : IEntityTypeConfiguration<CourseSession>
    {
        public void Configure(EntityTypeBuilder<CourseSession> builder)
        {
            builder.HasOne(cs => cs.Instructor).WithMany(i => i.CourseSessions);
            builder.HasOne(cs => cs.Course).WithMany(i => i.CourseSessions);
            builder.HasData(DemoData.GetDemoCourseSession());
        }
    }
}
