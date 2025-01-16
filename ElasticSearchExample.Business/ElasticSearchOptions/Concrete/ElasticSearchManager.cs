using ElasticSearchExample.Business.ElasticSearchOptions.Abstract;
using Nest;

namespace ElasticSearchExample.Business.ElasticSearchOptions.Concrete
{
    public class ElasticSearchManager : IElasticSearchService
    {
        public IElasticClient elasticClient { get; set; }
        private readonly IElasticSearchConfigration _elasticSearchConfigration;
        public ElasticSearchManager(IElasticSearchConfigration elasticSearchConfigration)
        {
            _elasticSearchConfigration = elasticSearchConfigration;
            elasticClient = GetClient();
        }

        private ElasticClient GetClient()
        {
            var str = _elasticSearchConfigration.ConnectionString;
            var strs = str.Split('|');
            var nodes = strs.Select(s => new Uri(s)).ToList();

            var connectionString = new ConnectionSettings(new Uri(str))
                .DisablePing()
                .SniffOnStartup(false)
                .SniffOnConnectionFault(false);

            if (!string.IsNullOrEmpty(_elasticSearchConfigration.AuthUserName) && !string.IsNullOrEmpty(_elasticSearchConfigration.AuthPassword))
                connectionString.BasicAuthentication(_elasticSearchConfigration.AuthUserName, _elasticSearchConfigration.AuthPassword);

            return new ElasticClient(connectionString);
        }
        public Task AddOrUpdateAsync<T, TKey>(string indexName, T model) where T : ElasticEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public virtual async Task CreateIndexAsync<T, TKey>(string indexName) where T : ElasticEntity<TKey>
        {
            //var exis = await elasticClient.IndexExistAsync(indexName);
        }

        public Task DeleteAsync<T, TKey>(string indexName, string typeName, T model) where T : ElasticEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public Task DeleteIndexAsync(string indexName)
        {
            throw new NotImplementedException();
        }

        public Task ReIndex<T, TKey>(string indexName) where T : ElasticEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public Task<ISearchResponse<T>> SearchAsync<T, TKey>(string indexName, SearchDescriptor<T> query, int skip, int size, string[] includeFields = null, string preTags = "<strong style=\"color:red;\">", string postTags = "</strong>", bool disableHigh = false, params string[] highField) where T : ElasticEntity<TKey>
        {
            throw new NotImplementedException();
        }

        public Task<ISearchResponse<T>> SimpleSearchAsync<T, TKey>(string indexName, SearchDescriptor<T> query) where T : ElasticEntity<TKey>
        {
            throw new NotImplementedException();
        }
    }
}
