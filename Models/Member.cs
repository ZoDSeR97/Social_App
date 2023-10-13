using System.ComponentModel.DataAnnotations;

namespace Social_App.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int CommunityId { get; set; }

        // Navigation Properties
        public User? Unit { get; set; }
        public Community? Organization { get; set; }
    }
}
