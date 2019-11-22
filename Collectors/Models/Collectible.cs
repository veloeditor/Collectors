using System;
using System.ComponentModel.DataAnnotations;

namespace Collectors.Models
{
    public class Collectible
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(55)]
        public string Name { get; set; }
        [MaxLength(4000)]
        public string Description { get; set; }

        [Required]
        public DateTime CollectedDate { get; set; }

        public int CollectionId { get; set; }
        public Collection Collection { get; set; }
    }
}