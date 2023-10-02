using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_App.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MinLength(2)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Last Name")]
        [MinLength(2)]
        public string LastName { get; set; } = string.Empty;

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

        // Need to look into uploading file
        public string Avatar { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        //Navigation Properties
       

    }
}
