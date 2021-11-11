using Microsoft.EntityFrameworkCore;

namespace Projects.Models
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<_Task> Tasks { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Employee>().ToTable("Employee");
           modelBuilder.Entity<_Task>().ToTable("Task");
          //modelBuilder
          //         .Entity<_Task>(
          //  eb =>
          //  {
          //      eb.HasNoKey();
          //      eb.ToView("View_BlogPostCounts");
          //      eb.Property(v => v.BlogName).HasColumnName("Task");
          //  });
        }
    }
}
