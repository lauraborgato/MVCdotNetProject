using System;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using MVCdotNetProject.Models;
using MVCdotNetProject.Interfaces.Repositories;

namespace MVCdotNetProject.Repositories
{
    public class PostRepository: IPostRepository
    {
        private readonly IMongoCollection<Post> _posts;
        public PostRepository(IPostDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _posts = database.GetCollection<Post>(settings.PostCollectionName);
        }

        public List<Post> Get() =>
           _posts.Find(post => true).ToList();

        public Post Get(string id) =>
            _posts.Find<Post>(post => post.Id == id).FirstOrDefault();

        public Post Create(Post post)
        {
            _posts.InsertOne(post);
            return post;
        }

        public void Update(string id, Post postIn) =>
            _posts.ReplaceOne(post => post.Id == id, postIn);

        public void Remove(Post postIn) =>
            _posts.DeleteOne(post => post.Id == postIn.Id);

        public void Remove(string id) =>
            _posts.DeleteOne(post => post.Id == id);

    }
}