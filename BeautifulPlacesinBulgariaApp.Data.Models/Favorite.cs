using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BeautifulPlacesinBulgariaApp.Data.Models
{
    [PrimaryKey(nameof(UserId), nameof(LocationId))]
    public class Favorite
    {
        [Required]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public Guid LocationId { get; set; }
        public LocationPost Location { get; set; } = null!;
    }
}