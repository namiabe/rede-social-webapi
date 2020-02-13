using AvanadeProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProject.Domain.Interfaces.Repositories
{
    public interface IGalleryRepository : IRepositoryBase<Gallery>
    {
        Gallery GetFeedByUserId(Guid userId);
    }
}
