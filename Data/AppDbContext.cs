using Microsoft.EntityFrameworkCore;
using GraphQL.Net5.Models;

namespace GraphQL.Net5.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<Platform> Platforms {get; set;}
        protected AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}