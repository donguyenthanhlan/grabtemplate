using System;
using System.Collections.Generic;
using GrabTemplate.Common.Models;

namespace GrabTemplate.Domain
{
    public class Lang : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public virtual ICollection<LangDetail> LangDetails { get; set; }
        public virtual ICollection<LangMsgDetail> LangMsgDetails { get; set; }
        public virtual ICollection<EmailTemplate> EmailTemplates { get; set; }
    }
}
