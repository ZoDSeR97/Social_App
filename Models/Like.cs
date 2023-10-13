using System.ComponentModel.DataAnnotations;

namespace Social_App.Models
{
    public class Like
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int PostId { get; set; }

        // Navigation Properties
        public User? Viewer { get; set; }
        public Post? LikedPost { get; set; }
    }
}
