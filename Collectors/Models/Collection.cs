using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Collectors.Models
{
    public class Collection
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(55)]
        public string Name { get; set; }

        public List<Collectible> Collectibles {get; set;}

        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}