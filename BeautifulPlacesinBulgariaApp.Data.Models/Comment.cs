using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeautifulPlacesinBulgariaApp.Data.Models
{
    public class Comment
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Content { get; set; } = null!;

        [Required]
        public DateTime DateCreated { get; set; }

        
        [Required]
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public Guid LocationPostId { get; set; }

        [ForeignKey(nameof(LocationPostId))]
        public LocationPost LocationPost { get; set; } = null!;

       

       
    }
}