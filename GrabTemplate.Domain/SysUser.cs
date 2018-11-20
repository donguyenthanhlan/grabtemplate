using System;
using GrabTemplate.Common.Models;

namespace GrabTemplate.Domain
{
    public class SysUser : EntityIdentity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsAdmin { get; set; }
        public string ResetPasswordToken { get; set; }
        public DateTime? ResetPasswordDate { get; set; }
        public string ActivateToken { get; set; }
        public bool IsUnsubscribed { get; set; }
    }
}
