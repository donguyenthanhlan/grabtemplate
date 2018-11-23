using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class LangMsgDetailService : CoreBase<LangMsgDetail>, ILangMsgDetailService
    {
        private readonly IRepositoryAsync<LangMsgDetail> _repository;

        public LangMsgDetailService(IRepositoryAsync<LangMsgDetail> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
