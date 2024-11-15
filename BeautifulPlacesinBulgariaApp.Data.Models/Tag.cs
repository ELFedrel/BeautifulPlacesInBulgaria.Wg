using System.ComponentModel.DataAnnotations;

namespace BeautifulPlacesinBulgariaApp.Data.Models
{
    using static BeautifulPlacesinBulgariaApp.Common.EntityConstants.Tag;

    public class Tag
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [MinLength(NameMinLength)]
        public string Name { get; set; } = null!;

        
        public ICollection<LocationPost> LocationPosts { get; set; } = new List<LocationPost>();
    }
}