using AvanadeProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProject.Domain.Interfaces.Applications
{
    public interface IApplicationBase<TEntity> : IBase<TEntity> where TEntity : BaseEntity
    {
    }
}
