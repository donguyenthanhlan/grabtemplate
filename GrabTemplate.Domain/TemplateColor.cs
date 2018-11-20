using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Common.Models;

namespace GrabTemplate.Domain
{
    public class TemplateColor : Entity
    {
        public int TemplateId { get; set; }
        public virtual Template Template { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }
    }
}
