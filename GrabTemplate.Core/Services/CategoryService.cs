using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class CategoryService : CoreBase<Category>, ICategoryService
    {
        private readonly IRepositoryAsync<Category> _repository;

        public CategoryService(IRepositoryAsync<Category> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
