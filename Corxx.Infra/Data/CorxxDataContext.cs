using Corxx.Domain.Entities;
using Corxx.Infra.Data.Maps;
using Microsoft.EntityFrameworkCore;

namespace Corxx.Infra.Data
{
    public class CorxxDataContext : DbContext
    {
        public CorxxDataContext(string connectionStrings)
        {
            _connectionStrings = connectionStrings;
        }

        public string _connectionStrings { get; private set; }


        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionStrings);
        }
    }
}
