using ElasticSearchExample.Business.ElasticSearchOptions.Concrete;
using Nest;

namespace ElasticSearchExample.Business.ElasticSearchOptions.Abstract
{
    public interface IElasticSearchService
    {
        Task CreateIndexAsync<T, TKey>(string indexName) where T : ElasticEntity<TKey>;
        Task DeleteIndexAsync(string indexName);
        Task AddOrUpdateAsync<T, TKey>(string indexName, T model) where T : ElasticEntity<TKey>;
        Task DeleteAsync<T, TKey>(string indexName, string typeName, T model) where T : ElasticEntity<TKey>;
        Task ReIndex<T, TKey>(string indexName) where T : ElasticEntity<TKey>;
        Task<ISearchResponse<T>> SimpleSearchAsync<T, TKey>(string indexName, SearchDescriptor<T> query) where T : ElasticEntity<TKey>;
        Task<ISearchResponse<T>> SearchAsync<T, TKey>(string indexName, SearchDescriptor<T> query, int skip, int size, string[] includeFields = null, 
            string preTags = "<strong style=\"color:red;\">", string postTags = "</strong>", bool disableHigh = false, params string[] highField) where T : ElasticEntity<TKey>;
    }
}
