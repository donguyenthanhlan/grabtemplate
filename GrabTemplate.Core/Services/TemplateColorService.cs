using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class TemplateColorService : CoreBase<TemplateColor>, ITemplateColorService
    {
        private readonly IRepositoryAsync<TemplateColor> _repository;

        public TemplateColorService(IRepositoryAsync<TemplateColor> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
