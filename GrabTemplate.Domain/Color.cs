using System;
using System.Collections.Generic;
using GrabTemplate.Common.Models;

namespace GrabTemplate.Domain
{
    public class Color : Entity
    {
        public int Id { get; set; }
        public string CssClass{ get; set; }
        public string Value { get; set; }

        public virtual ICollection<TemplateColor> TemplateColors { get; set; }
    }
}
