using AutoMapper;
using GrabTemplate.Domain;
using GrabTemplate.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrabTemplate.Core.Misc.AutoMapper
{
    public class SysUserProfile : Profile
    {
        public SysUserProfile()
        {
            CreateMap<SysUser, SysUserDTO>();
        }
    }
}
