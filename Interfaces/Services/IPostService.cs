using System;
using System.Collections;
using System.Collections.Generic;
using MVCdotNetProject.Models;

namespace MVCdotNetProject.Interfaces.Service
{
    public interface IPostService
    {
        List<Post> GetAllPosts();
        Post GetPostsById(string id);
        string AddNewPost(Post post);
        string EditPost(Post post);
        string RemovePost(string id);
    }
}