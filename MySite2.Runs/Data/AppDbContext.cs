using Microsoft.EntityFrameworkCore;
using MySite2.Runs.Models;

namespace MySite2.Runs.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
        }

        public DbSet<Run> Runs { get; set; }
    }
}