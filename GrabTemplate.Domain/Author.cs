using System;
using System.Collections.Generic;
using GrabTemplate.Common.Models;

namespace GrabTemplate.Domain
{
    public class Author : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }

        public virtual ICollection<Template> Templates { get; set; }
    }
}
