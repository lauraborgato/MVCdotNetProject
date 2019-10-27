using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MVCdotNetProject.Models
{
    [BsonIgnoreExtraElements]
    public class Post
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("postTitle")]
        public string Title { get; set; }
        [BsonElement("postContent")]
        public string Content { get; set; }
        [BsonElement("imagePath")]
        public string Photo { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("userId")]
        public string UserId { get; set; }
    }
}