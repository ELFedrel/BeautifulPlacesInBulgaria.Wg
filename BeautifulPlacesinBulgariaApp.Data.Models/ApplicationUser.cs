using Microsoft.AspNetCore.Identity;

namespace BeautifulPlacesinBulgariaApp.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {

        public string? ProfilePictureURL { get; set; }
        public string? Bio { get; set; }

        
        public ICollection<LocationPost> LocationPosts { get; set; } = new List<LocationPost>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
