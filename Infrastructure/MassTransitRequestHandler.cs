using MassTransit;
using Shared;

namespace Infrastructure;

public abstract class MassTransitRequestHandler<TRequest, TResponse>
    : IConsumer<TRequest>, IQueryHandler<TRequest, TResponse>
    where TRequest : QueryRequest
    where TResponse : QueryResponse
{
    public async Task Consume(ConsumeContext<TRequest> context)
    {
        var request = context.Message;
        var response = await HandleQuery(request);
        await context.RespondAsync(response);
    }

    public abstract Task<TResponse> HandleQuery(TRequest request);
}