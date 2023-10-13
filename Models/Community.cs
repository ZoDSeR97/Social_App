using System.ComponentModel.DataAnnotations;

namespace Social_App.Models
{
    public class Community
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Navigation Properties
        public User? Creator { get; set; }
        public List<Member> Members { get; set; } = new List<Member>();
    }
}
