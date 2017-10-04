using System.Data.Entity;

namespace EmployeeManagementSystem.Data
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    /// <remarks>
    /// Where’s My Data?
    /// By convention DbContext has created a database for you.
    /// - If a local SQL Express instance is available(installed by default with Visual Studio 2010) then Code First has created the database on that instance
    /// - If SQL Express isn’t available then Code First will try and use LocalDb(installed by default with Visual Studio 2012)
    /// - The database is named after the fully qualified name of the derived context, in our case that is EmployeeManagementSystem.Data.EmployeeManagementContext
    /// </remarks>
    public class EmployeeManagementContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}