using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeManagementSystem.Data
{
    public class EmployeeManagementContext : DbContext
    {
        public EmployeeManagementContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=EmployeeManagement;Trusted_Connection=True;TrustServerCertificate=True;");            
        }
    }
}