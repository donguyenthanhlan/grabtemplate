using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Common.Models;

namespace GrabTemplate.Domain
{
    public class EmailTemplate : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public int LangId { get; set; }

        public Lang Lang { get; set; }
    }
}
