using AvanadeProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProject.Domain.Interfaces.Services
{
    public interface IPostService : IServiceBase<Post>
    {
        IEnumerable<Post> GetFeedByUserId(Guid userId);
    }
}
