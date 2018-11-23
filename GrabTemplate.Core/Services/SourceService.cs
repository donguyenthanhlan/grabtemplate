using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class SourceService : CoreBase<Source>, ISourceService
    {
        private readonly IRepositoryAsync<Source> _repository;

        public SourceService(IRepositoryAsync<Source> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
