using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using GrabTemplate.Common.Interfaces;
using Npgsql;

namespace GrabTemplate.Infrastructure.Interfaces
{
    public interface IDataContext : IDisposable
    {
        int SaveChanges();
        void SyncObjectState<TEntity>(TEntity entity) where TEntity : class, IObjectState;
        void SyncObjectsStatePostCommit();
        void ExecuteSqlCommand(RawSqlString sql, params object[] parameters);
        DataSet ExecuteStoredProcedure(string sqlCommandText, IList<NpgsqlParameter> parameters);
    }
}
