using System;
using GrabTemplate.Common.Models;

namespace GrabTemplate.Domain
{
    public class DownloadToken : Entity
    {
        public int Id { get; set; }
        public string Token{ get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
