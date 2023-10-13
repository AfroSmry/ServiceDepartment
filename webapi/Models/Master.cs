using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Master
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string SecondName { get; set; }
        public string Name { get; set; } 
        public string Surname { get; set; } 
        public string Phone { get; set; } 

    }
}
