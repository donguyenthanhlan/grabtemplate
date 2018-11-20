using System;
using GrabTemplate.Common.Models;

namespace GrabTemplate.Domain
{
    public class LangMsgDetail : Entity
    {
        public int Id { get; set; }
        public int LangId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public virtual Lang Lang { get; set; }
    }
}
