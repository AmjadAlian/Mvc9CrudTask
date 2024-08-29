using Microsoft.EntityFrameworkCore;
using Mvc9CrudTask.Models;

namespace Mvc9CrudTask.Data
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;database=EF9_CrudTask;trusted_connection=true;trustServerCertificate=True");
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
