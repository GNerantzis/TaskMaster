using System.Data.Entity;

namespace TaskMaster4GN.Model
{
     class tmDbContext : DbContext
    {
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
