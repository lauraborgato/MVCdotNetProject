using System;
using System.Collections;
using System.Collections.Generic;
using MVCdotNetProject.Models;

namespace MVCdotNetProject.Interfaces.Repositories
{
    public interface IPostRepository
    {
        List<Post> Get();
        Post Get(string id);
        Post Create(Post post);
        void Update(string id, Post postIn);
        void Remove(Post postIn);
        void Remove(string id);
    }
}

