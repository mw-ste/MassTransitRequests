namespace Shared;

public interface IRequester<TRequest, TResponse>
    where TRequest : QueryRequest
    where TResponse : QueryResponse
{
    public Task<TResponse> Get(TRequest request);
}