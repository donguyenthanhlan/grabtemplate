using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using GrabTemplate.Common.Enums;
using GrabTemplate.Common.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GrabTemplate.Common.Models
{
    public class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }

    public class EntityIdentity : IdentityUser, IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}
