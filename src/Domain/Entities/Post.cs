﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AvanadeProject.Domain.Entities
{
    public class Post : BaseEntity
    {
        public Post()
        {
            Midias = new List<Midia>();
            Likes = new List<Like>();
            Comments = new List<Post>();
            Author = new User();
            ParentId = null;
        }

        public Guid? ParentId { get; set; }
        public string Text { get; set; }
        public List<Midia> Midias { get; set; }
        public List<Midia> Likes { get; set; }
        public List<Post> Comments { get; set; }
        public Guid AuthorId { get; set; }
        public User Author { get; set; }

        public override void Validate()
        {
            if (AuthorId == Guid.Empty)
                throw new ArgumentNullException("'AuthorId' não foi preenchido");
        }
    }
}
