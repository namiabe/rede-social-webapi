using AvanadeProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AvanadeProject.Domain.Interfaces
{
    public interface IBase<TEntity> where TEntity : BaseEntity
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(Guid id);
        Guid Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(Guid id);
    }
}
