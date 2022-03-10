using MassTransit;
using Shared;
using Response = Shared.Response;

namespace Infrastructure;

public class MassTransitRequester<TRequest, TResponse> 
    : IRequester<TRequest, TResponse>
    where TRequest : Request
    where TResponse : Response
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