using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class SubscriberService : CoreBase<Subscriber>, ISubscriberService
    {
        private readonly IRepositoryAsync<Subscriber> _repository;

        public SubscriberService(IRepositoryAsync<Subscriber> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
