using Microsoft.EntityFrameworkCore;
using Social_App.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace Social_App.Models
{
    public class Follow
    {
        [Key]
        public int Id { get; set; }

        public int FollowerId { get; set; }

        public int FolloweeId { get; set; }

        // Navigation Properties
        public User? Follower { get; set; }
        public User? Followee { get; set; }
    }
}

