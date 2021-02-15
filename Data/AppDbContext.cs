using Microsoft.EntityFrameworkCore;
using GraphQL.Net5.Models;

namespace GraphQL.Net5.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Platform> Platforms { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}