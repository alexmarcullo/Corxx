using Corxx.Domain.Entities;
using Corxx.Infra.Data.Maps;
using Microsoft.EntityFrameworkCore;

namespace Corxx.Infra.Data
{
    public class CorxxDataContext : DbContext
    {
        public CorxxDataContext(DbContextOptions<CorxxDataContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
