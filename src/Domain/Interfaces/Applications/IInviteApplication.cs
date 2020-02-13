using AvanadeProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProject.Domain.Interfaces.Applications
{
    public interface IInviteApplication : IApplicationBase<Invite>
    {
        IEnumerable<Invite> GetByUserId(Guid userId);
    }
}
