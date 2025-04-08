using Microsoft.EntityFrameworkCore;

namespace CourseSystem_DAL
{
    public class MyContext:DbContext
    {
        #region DBSet

        public DbSet<Instructor>? Instructors { get; set; }
        public DbSet<Department>? Departments { get; set; }

        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=.;Database=CourseSystem;Trusted_Connection=true;TrustServerCertificate=true;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
