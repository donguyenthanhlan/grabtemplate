using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class SettingService : CoreBase<Setting>, ISettingService
    {
        private readonly IRepositoryAsync<Setting> _repository;

        public SettingService(IRepositoryAsync<Setting> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
