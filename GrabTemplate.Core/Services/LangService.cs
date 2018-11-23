using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class LangService : CoreBase<Lang>, ILangService
    {
        private readonly IRepositoryAsync<Lang> _repository;

        public LangService(IRepositoryAsync<Lang> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
