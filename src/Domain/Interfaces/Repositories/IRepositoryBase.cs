using AvanadeProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProject.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> : IBase<TEntity> where TEntity : BaseEntity
    {
        void Execute(string sql, object parameters);
        IEnumerable<T> Execute<T>(string aql, object parameters);
    }
}
