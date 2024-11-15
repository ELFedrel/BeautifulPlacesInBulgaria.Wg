using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BeautifulPlacesinBulgariaApp.Data.Models
{
    using static BeautifulPlacesinBulgariaApp.Common.EntityConstants.User;

    public class ApplicationUser : IdentityUser<Guid>
    {
        
        public string? ProfilePictureURL { get; set; }

        [MaxLength(BioMaxLength)]
        public string? Bio { get; set; }

        public ICollection<LocationPost> LocationPosts { get; set; } = new List<LocationPost>();
        public ICollection<FavoriteViews> Favorites { get; set; } = new List<FavoriteViews>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
