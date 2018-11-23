using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class TemplateService : CoreBase<Template>, ITemplateService
    {
        private readonly IRepositoryAsync<Template> _repository;

        public TemplateService(IRepositoryAsync<Template> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
