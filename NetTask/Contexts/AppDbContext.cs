using Microsoft.EntityFrameworkCore;
using NetTask.Models;
using System.Security.Cryptography.X509Certificates;

namespace NetTask.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
