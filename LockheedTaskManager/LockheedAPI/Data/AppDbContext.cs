using Microsoft.EntityFrameworkCore;
using LockheedAPI.Models;

namespace LockheedAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TaskItem> TaskItems => Set<TaskItem>();
    }
}