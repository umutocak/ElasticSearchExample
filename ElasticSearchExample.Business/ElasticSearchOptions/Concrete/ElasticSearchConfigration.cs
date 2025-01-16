using ElasticSearchExample.Business.ElasticSearchOptions.Abstract;
using Microsoft.Extensions.Configuration;

namespace ElasticSearchExample.Business.ElasticSearchOptions.Concrete
{
    public class ElasticSearchConfigration : IElasticSearchConfigration
    {
        public IConfiguration Configuration { get; }
        public ElasticSearchConfigration(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public string ConnectionString { get { return Configuration.GetSection("ElasticSearchOptions:ConnectionString:HostUrls").Value; } }
        public string AuthUserName { get { return Configuration.GetSection("ElasticSearchOptions:ConnectionString:UserName").Value; } }
        public string AuthPassword { get { return Configuration.GetSection("ElasticSearchOptions:ConnectionString:Password").Value; } }
    }
}
