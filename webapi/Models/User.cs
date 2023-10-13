using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string SecondName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
    }
}
