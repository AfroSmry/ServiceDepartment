using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Order
    {
        [Required]
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime TimeSpend { get; set; }
        public User User { get; set; }
        public Master Master { get; set; }
        public  ICollection<WorkType> WorkTypes { get; set; }
    }
}
