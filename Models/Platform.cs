using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotChocolate;

namespace GraphQL.Net5.Models
{
    [GraphQLDescription("Description about Platform")]
    public class Platform
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }
        [GraphQLDescription("Description about Platform")]
        public string Key {get; set;}

        public ICollection<Command> Commands {get; set;} = new List<Command>();
    }
}