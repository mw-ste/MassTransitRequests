namespace Shared;

public interface IQueryHandler
{
}

public interface IQueryHandler<TRequest, TResponse>
    : IQueryHandler
    where TRequest : QueryRequest
    where TResponse : QueryResponse
{
    public Task<TResponse> HandleQuery(TRequest request);
}