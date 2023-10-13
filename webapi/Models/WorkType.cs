using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class WorkType
    {
        [Required]
        public int Id { get; set; }
        public string WorkName { get; set; }
        public float Tariff { get; set; }
        public float Price { get; set; }
    }
}
