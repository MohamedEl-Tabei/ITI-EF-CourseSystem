using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSystem_DAL
{
    public class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            #region Relation with department
            builder.HasOne(I => I.Department).WithMany(D => D.Instructors).HasForeignKey("DepartmentId");
            #endregion
            builder.Property(H => H.FirstName).IsRequired().HasMaxLength(255);
            builder.Property(H => H.LastName).IsRequired().HasMaxLength(255);
            builder.Property(H => H.Phone).IsRequired().HasMaxLength(255);
            builder.HasData(DemoData.GetDemoInstructors());
        }
    }
}
