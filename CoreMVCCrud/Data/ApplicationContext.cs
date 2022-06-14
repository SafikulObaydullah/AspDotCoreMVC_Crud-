using CoreMVCCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreMVCCrud.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
