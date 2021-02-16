using GraphQL.Net5.Models;
using HotChocolate.Types;

namespace GraphQL.Net5.GraphQ.Platforms
{
    class PlatformsType : ObjectType<Platform>
    {
        protected override void Configure(IObjectTypeDescriptor<Platform> descriptor)
        {
            descriptor.Description("This is description");

            descriptor.Field(x=>x.Key).Ignore();
        }
    }
}