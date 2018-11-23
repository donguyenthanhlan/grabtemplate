using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class LangDetailService : CoreBase<LangDetail>, ILangDetailService
    {
        private readonly IRepositoryAsync<LangDetail> _repository;

        public LangDetailService(IRepositoryAsync<LangDetail> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
