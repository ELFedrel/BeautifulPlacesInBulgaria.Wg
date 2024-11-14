using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeautifulPlacesinBulgariaApp.Data.Models
{
    public class LocationPost
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string PhotoURL { get; set; }

        [Required]
        public DateTime DatePosted { get; set; }

      

        // Foreign Key for the user who created the post
        [Required]
        public string UserId { get; set; }

        // Navigation Properties
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
       
    }
}