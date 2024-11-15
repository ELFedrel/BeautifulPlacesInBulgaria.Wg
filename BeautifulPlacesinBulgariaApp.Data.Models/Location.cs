using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulPlacesinBulgariaApp.Data.Models
{
    using static BeautifulPlacesinBulgariaApp.Common.EntityConstants.Location;

    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [MinLength(NameMinLength)]
        public string Name { get; set; } = null!;

        public ICollection<LocationPost> LocationPosts { get; set; } = new List<LocationPost>();
    }
}
