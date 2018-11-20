using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Common.Models;

namespace GrabTemplate.Domain
{
    public class Setting : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
