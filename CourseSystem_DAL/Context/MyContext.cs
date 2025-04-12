using CourseSystem_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseSystem_DAL
{
    public class MyContext:DbContext
    {
        #region DBSet
        public DbSet<CourseSession> CourseSessions { get; set; }
        public DbSet<Instructor>? Instructors { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<StudentCourse>? StudentCourses { get; set; }
        public DbSet<CourseSessionAttendance>? CourseSessionAttendances { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=.;Database=CourseSystemEF;Trusted_Connection=true;TrustServerCertificate=true;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
