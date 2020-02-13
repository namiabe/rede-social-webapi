using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProject.Domain.Entities
{
    public class InviteStatus : BaseEntity
    {
        public string Description { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrWhiteSpace(Description))
                throw new ArgumentNullException("'Description' não foi preenchido");
        }
    }
}
