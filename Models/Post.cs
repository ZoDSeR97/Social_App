using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_App.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Navigation Properties
        public User? Creator { get; set; }
        public List<Like> Likes { get; set; } = new List<Like>();
        public List<Comment> Comments { get; set;} = new List<Comment>();
        public Comment? Op { get; set; }
    }
}
