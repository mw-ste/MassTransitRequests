namespace Shared;

public interface IRequester<TRequest, TResponse>
    where TRequest : Request
    where TResponse : Response
{
    public Task<TResponse> Get(TRequest request);
}