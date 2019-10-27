using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MVCdotNetProject.Models;
using MVCdotNetProject.Interfaces.Service;
using MVCdotNetProject.Interfaces.Repositories;

namespace MVCdotNetProject.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public List<Post> GetAllPosts()
        {
            return _postRepository.Get();
        }

        public Post GetPostsById(string id)
        {
            return _postRepository.Get(id);

        }
        public string AddNewPost(Post post){
            return null;
        }
        public string EditPost(Post post){
            return null;
        }
        public string RemovePost(string id){
            return null;
        }

    }
}