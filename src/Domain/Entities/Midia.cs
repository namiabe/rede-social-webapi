using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProject.Domain.Entities
{
    public class Midia : BaseEntity
    {
        public string Description { get; set; }
        public Guid MidiaTypeId { get; set; }
        public MidiaType MidiaType { get; set; }
        public string Path { get; set; }
        public override void Validate()
        {
            if (String.IsNullOrWhiteSpace(Description))
                throw new ArgumentNullException("'Description' não foi preenchido");

            if (MidiaTypeId == Guid.Empty)
                throw new ArgumentNullException("'MidiaTypeId' não foi preenchido");

            if (String.IsNullOrWhiteSpace(Path))
                throw new ArgumentNullException("'Path' não foi preenchido");
        }
    }
}
