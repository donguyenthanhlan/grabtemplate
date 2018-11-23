using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class ColorService : CoreBase<Color>, IColorService
    {
        private readonly IRepositoryAsync<Color> _repository;

        public ColorService(IRepositoryAsync<Color> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
