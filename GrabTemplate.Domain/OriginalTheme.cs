using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Common.Models;

namespace GrabTemplate.Domain
{
    public class OriginalTheme : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int? ParentId { get; set; }
        public int Count { get; set; }

        public virtual ICollection<Template> Templates { get; set; }
    }
}
