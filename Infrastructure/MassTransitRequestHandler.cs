using MassTransit;
using Shared;
using Response = Shared.Response;

namespace Infrastructure;

public abstract class MassTransitRequestHandler<TRequest, TResponse>
    : IConsumer<TRequest>, IRequestHandler<TRequest, TResponse>
    where TRequest : Request
    where TResponse : Response
{
    public async Task Consume(ConsumeContext<TRequest> context)
    {
        var request = context.Message;
        var response = await HandleQuery(request);
        await context.RespondAsync(response);
    }

    public abstract Task<TResponse> HandleQuery(TRequest request);
}