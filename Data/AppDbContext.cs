using Microsoft.EntityFrameworkCore;
using GraphQL.Net5.Models;

namespace GraphQL.Net5.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Command> Commands { get; set; }
        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Platform>()
                        .HasMany(p=>p.Commands)
                        .WithOne(p=>p.Platform)
                        .HasForeignKey(p=>p.PlatformId);
            modelBuilder.Entity<Command>()
                        .HasOne(p=>p.Platform)
                        .WithMany(p=>p.Commands)
                        .HasForeignKey(p=>p.PlatformId);
        }
    }
}