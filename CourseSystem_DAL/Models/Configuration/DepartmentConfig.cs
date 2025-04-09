using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseSystem_DAL
{
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            #region Relation with manager
            builder.HasOne(D => D.Manager).WithOne(I => I.ManagedDepartment).HasForeignKey<Department>(D => D.ManagerId);
            #endregion
            builder.Property(D=>D.Name).IsRequired().HasMaxLength(255);
            builder.Property(D=>D.Location).HasMaxLength(255);
            builder.HasData(DemoData.GetDemoDepartments());
        }
    }
}
