using GrabTemplate.Common.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace GrabTemplate.Infrastructure.Interfaces
{
    public interface IQueryFluent<TEntity> where TEntity : IObjectState
    {
        IQueryFluent<TEntity> OrderBy(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);
        IIncludableQueryable<TEntity, TResult> Include<TResult>(Expression<Func<TEntity, TResult>> expression);
        IQueryable<TEntity> SqlQuery(string query, params object[] parameters);
    }
}
