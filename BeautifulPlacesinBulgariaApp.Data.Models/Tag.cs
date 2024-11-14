using System.ComponentModel.DataAnnotations;

namespace BeautifulPlacesinBulgariaApp.Data.Models
{
    public class Tag
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        
        public ICollection<LocationPost> LocationPosts { get; set; } = new List<LocationPost>();
    }
}