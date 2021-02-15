using System.Linq;
using GraphQL.Net5.Data;
using GraphQL.Net5.Models;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQL.Net5.GraphQ
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        public IQueryable<Platform> GetPlatforms([ScopedService] AppDbContext context)
        {
            return context.Platforms;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        public IQueryable<Command> GetCommands([ScopedService] AppDbContext context)
        {
            return context.Commands;
        }
    }
}