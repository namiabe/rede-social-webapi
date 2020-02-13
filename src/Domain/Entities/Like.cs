using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProject.Domain.Entities
{
    public class Like : BaseEntity
    {
        public Like()
        {
            Post = new Post();
            User = new User();
        }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
