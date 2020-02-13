﻿using AvanadeProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProject.Domain.Interfaces.Services
{
    public interface IGalleryService : IServiceBase<Gallery>
    {
        Gallery GetFeedByUserId(Guid userId);
    }
}
