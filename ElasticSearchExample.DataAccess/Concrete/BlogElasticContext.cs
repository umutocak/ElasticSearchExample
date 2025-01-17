using ElasticSearchExample.Entities.Concrete.Auth;
using ElasticSearchExample.Entities.Concrete.Categories;
using ElasticSearchExample.Entities.Concrete.Comments;
using ElasticSearchExample.Entities.Concrete.Posts;
using ElasticSearchExample.Entities.Concrete.PostTags;
using ElasticSearchExample.Entities.Concrete.Tags;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ElasticSearchExample.DataAccess.Concrete
{
    public class BlogElasticContext : DbContext
    {
        public BlogElasticContext(DbContextOptions options, ILogger logger) : base(options) { }
        public BlogElasticContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(getAppSettingsFile().GetConnectionString("DefaultConnection"));
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        private IConfigurationRoot getAppSettingsFile()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
           .AddJsonFile("appsettings.json")
           .Build();
            return configuration;
        }
    }
}
