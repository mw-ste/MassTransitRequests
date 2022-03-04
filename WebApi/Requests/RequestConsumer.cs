using MassTransit;

namespace WebApi.Requests;

public class RequestConsumer : IConsumer<Request>
{
    public Task Consume(ConsumeContext<Request> context)
    {
        throw new NotImplementedException();
    }
}