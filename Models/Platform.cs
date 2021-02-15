using System.ComponentModel.DataAnnotations;

namespace GraphQL.Net5.Models
{
    public class Platform
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }
        public string Key {get; set;}
    }
}