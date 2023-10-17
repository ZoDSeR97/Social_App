using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_App.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        /* Loosely handshake */
        [Required]
        public string Clerk_Id { get; set; } = string.Empty;

        [Required]
        [Display(Name = "First Name")]
        [MinLength(2)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Last Name")]
        [MinLength(2)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [MinLength(2)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [NotMapped]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; } = string.Empty;

        public string Bio { get; set; } = string.Empty;

        // Need to look into uploading file
        public string Avatar { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        //Navigation Properties
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Like> Liked { get; set; } = new List<Like>();
        public List<Community> Communities { get; set; } = new List<Community>();
        public List<Member> Members { get; set; } = new List<Member>();
        public List<Follow> Followers { get; set; } = new List<Follow>();
        public List<Follow> Follows { get; set;} = new List<Follow>();
    }
}
