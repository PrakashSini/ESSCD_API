using ESSCD_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ESSCD_API.Services.DbConnection
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions<AppdbContext> options)
        : base(options)
        {
        }

        public DbSet<EmployeeMaster> EmployeeMaster { get; set; }
        public DbSet<Shifts> Shifts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
