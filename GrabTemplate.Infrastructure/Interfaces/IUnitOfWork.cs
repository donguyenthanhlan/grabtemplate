using GrabTemplate.Common.Interfaces;
using System;
using System.Data;

namespace GrabTemplate.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        void Dispose(bool disposing);
        IRepository<TEntity> Repository<TEntity>() where TEntity : class, IObjectState;
        bool Commit();
        void Rollback();
    }
}
