using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProject.Domain.Entities
{
    public class Gender : BaseEntity
    {
        public string Description { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrEmpty(Description))
                throw new ArgumentNullException("'Description' não fi preenchido");
        }
    }
}
