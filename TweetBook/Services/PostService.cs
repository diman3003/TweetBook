﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TweetBook.Domain;

namespace TweetBook.Services
{
    public class PostService : IPostService
    {
        private List<Post> _posts;

        public PostService()
        {
            _posts = new List<Post>();

            for (int i = 0; i < 5; i++)
            {
                _posts.Add(new Post
                {
                    Id = Guid.NewGuid(),
                    Name = $"Post Name {i}"
                });
            }
        }

        public List<Post> GetPosts()
        {
            return _posts;
        }

        public Post GetpostById(Guid postId)
        {
            return _posts.SingleOrDefault(x => x.Id == postId);
        }
    }
}
