using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collectors.Models
{
    public class CollectibleEditViewModel
    {
        public Collectible Collectible { get; set; }
        public List<Collection> Collections { get; set; }
        public List<SelectListItem> CollectionOptions
        {
            get
            {
                return Collections?.Select(c => new SelectListItem(c.Name, c.Id.ToString())).ToList();
            }
        }
    }
}