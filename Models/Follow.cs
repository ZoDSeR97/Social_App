using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_App.Models
{
    public class Follow
    {
        [Key]
        public int Id { get; set; }

        public int FollowerId { get; set; }

        public int FolloweeId { get; set; }

        // Navigation Properties
        [ForeignKey("FollowerId")]
        public User? Follower { get; set; }
        [ForeignKey("FolloweeId")]
        public User? Followee { get; set; }
    }
}

