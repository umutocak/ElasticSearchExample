namespace ElasticSearchExample.Business.ElasticSearchOptions.Abstract
{
    public interface IElasticSearchConfigration
    {
        string ConnectionString { get; }
        string AuthUserName { get; }
        string AuthPassword { get; }
    }
}
