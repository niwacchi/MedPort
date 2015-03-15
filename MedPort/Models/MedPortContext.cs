using System.Data.Entity;

namespace MedPort.Models
{
    public class MedPortContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
    }
}