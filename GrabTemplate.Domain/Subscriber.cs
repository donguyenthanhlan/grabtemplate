using System;
using System.Collections.Generic;
using GrabTemplate.Common.Models;

namespace GrabTemplate.Domain
{
    public class Subscriber : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
