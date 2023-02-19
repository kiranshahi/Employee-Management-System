using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Data
{
    public class EmployeeManagementContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=kirans;Database=EmployeeManagement;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}