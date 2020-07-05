using Blog;
using Grpc.Core;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Blog.BlogService;


namespace server
{
    class BlogServiceImpl : BlogServiceBase
    {
        private static MongoClient mongoClient = new MongoClient("mongodb://db1:27017");
        private static IMongoDatabase mongoDatabase = mongoClient.GetDatabase("mybd");
        private static IMongoCollection<BsonDocument> mongoCollection = mongoDatabase.GetCollection<BsonDocument>("blog");

        public override Task<CreatBlogResponse> CreateBlog(CreatBlogRequest request, ServerCallContext context)
        {
            var blog = request.Blog;
            BsonDocument doc = new BsonDocument("author_id", blog.AuthorId)
                                                .Add("title", blog.Title)
                                                .Add("content", blog.Content);
            mongoCollection.InsertOne(doc);
            string id = doc.GetValue("_id").ToString();
            blog.Id = id;

            return Task.FromResult(new CreatBlogResponse()
            {
                Blog = blog
            });
        }
    }
}
