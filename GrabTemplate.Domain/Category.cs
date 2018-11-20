using System;
using System.Collections.Generic;
using GrabTemplate.Common.Models;

namespace GrabTemplate.Domain
{
    public class Category : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string Icon { get; set; }
        public int Count { get; set; }
        public string ListingImage { get; set; }

        public virtual ICollection<Template> Templates { get; set; }
        public virtual Category Parent { get; set; }
    }
}
