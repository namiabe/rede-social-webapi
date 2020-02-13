using AvanadeProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProject.Domain.Interfaces.Repositories
{
    public interface IInviteRepository : IRepositoryBase<Invite>
    {
        IEnumerable<Invite> GetByUserId(Guid userId);
        IEnumerable<Invite> GetFriends(Guid userId);
    }
}
