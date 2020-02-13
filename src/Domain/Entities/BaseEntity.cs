using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProject.Domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
            Active = true;
        }

        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }

        public abstract void Validate();
    }
}
