using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Core.Interfaces;
using GrabTemplate.Domain;
using GrabTemplate.Infrastructure.Interfaces;

namespace GrabTemplate.Core.Services
{
    public class DownloadTokenService : CoreBase<DownloadToken>, IDownloadTokenService
    {
        private readonly IRepositoryAsync<DownloadToken> _repository;

        public DownloadTokenService(IRepositoryAsync<DownloadToken> repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
