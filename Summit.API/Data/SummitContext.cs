using Microsoft.EntityFrameworkCore;
using Summit.API.Entities;

namespace Summit.API.Data
{
    public class SummitContext : DbContext
    {
        public SummitContext(DbContextOptions<SummitContext> options) : base(options)
        {}

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
