using MassTransit;
using Shared;

namespace Infrastructure;

public class MassTransitRequester<TRequest, TResponse> 
    : IRequester<TRequest, TResponse>
    where TRequest : QueryRequest
    where TResponse : QueryResponse
{
    private readonly IRequestClient<TRequest> _requestClient;

    public MassTransitRequester(IRequestClient<TRequest> requestClient)
    {
        _requestClient = requestClient;
    }

    public async Task<TResponse> Get(TRequest request)
    {
        var response = await _requestClient.GetResponse<TResponse>(request);
        return response.Message;
    }
}