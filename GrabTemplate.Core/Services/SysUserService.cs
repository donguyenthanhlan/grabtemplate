using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class SysUserService : CoreBase<SysUser>, ISysUserService
    {
        private readonly IRepositoryAsync<SysUser> _repository;

        public SysUserService(IRepositoryAsync<SysUser> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
