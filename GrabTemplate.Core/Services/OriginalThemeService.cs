using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class OriginalThemeService : CoreBase<OriginalTheme>, IOriginalThemeService
    {
        private readonly IRepositoryAsync<OriginalTheme> _repository;

        public OriginalThemeService(IRepositoryAsync<OriginalTheme> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
