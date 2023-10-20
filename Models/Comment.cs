using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social_App.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public int OpId { get; set; }

        public int ReplyId { get; set; }

        // Navigation Properties
        [ForeignKey("OpId")]
        public Post? Op { get; set; }
        [ForeignKey("ReplyId")]
        public Post? Reply { get; set; }
    }
}
