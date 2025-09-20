using System.ComponentModel.DataAnnotations;

namespace CRUDph9.Models
{
    public class Studentcs
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Range(18, 35)]
        public int Age { get; set; }
        public DateTime? Birthday {  get; set; }
    }
}
