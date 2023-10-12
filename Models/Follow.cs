using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_App.Models
{
    public class Follow
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int FanId { get; set; }

        [Required]
        public int IdolId { get; set; }

        // Navigation Properties
        public User? Fan { get; set; }
        public User? Idol { get; set; }
    }
}
