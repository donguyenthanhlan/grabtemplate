using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class AuthorService : CoreBase<Author>, IAuthorService
    {
        private readonly IRepositoryAsync<Author> _repository;

        public AuthorService(IRepositoryAsync<Author> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
