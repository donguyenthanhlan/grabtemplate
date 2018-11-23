using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrabTemplate.DTOs
{
    public class SysUserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsAdmin { get; set; }
        public string ResetPasswordToken { get; set; }
        public DateTime? ResetPasswordDate { get; set; }
        public string ActivateToken { get; set; }
    }
}
