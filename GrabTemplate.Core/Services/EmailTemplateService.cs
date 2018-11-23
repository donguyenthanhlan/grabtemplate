using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class EmailTemplateService : CoreBase<EmailTemplate>, IEmailTemplateService
    {
        private readonly IRepositoryAsync<EmailTemplate> _repository;

        public EmailTemplateService(IRepositoryAsync<EmailTemplate> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
