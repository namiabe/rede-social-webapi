using AvanadeProject.Domain.Entities;
using AvanadeProject.Domain.Interfaces.Applications;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProjet.Domain.Interfaces.Applications
{
    public interface IPostApplication :IApplicationBase<Post>
    {
        IEnumerable<Post> GetFeedByUserId(Guid userId);
    }
}
