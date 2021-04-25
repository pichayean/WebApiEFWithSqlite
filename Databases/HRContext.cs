using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApiEFWithSqlite
{
    public class HRContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddress { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeesInProject> EmployeesInProjects { get; set; }
        public HRContext(DbContextOptions<HRContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<EmployeesInProject>()
                        .HasKey(e => new { e.EmployeeID, e.ProjectID });
            modelBuilder.Seed();
        }
    }
}