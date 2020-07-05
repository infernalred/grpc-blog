using Blog;
using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Channel channel = new Channel("localhost", 50052, ChannelCredentials.Insecure);
            await channel.ConnectAsync().ContinueWith((task) =>
            {
                if (task.Status == TaskStatus.RanToCompletion)
                    Console.WriteLine($"The client connected successfully");
            });

            var client = new BlogService.BlogServiceClient(channel);

            var response = client.CreateBlog(new CreatBlogRequest()
            {
                Blog = new Blog.Blog()
                {
                    AuthorId = "Alex",
                    Title = "New Blog",
                    Content = "Hello new blog"
                }
            });

            Console.WriteLine($"The blog {response.Blog.Id} was created");

            channel.ShutdownAsync().Wait();
            Console.ReadKey();
        }
    }
}
