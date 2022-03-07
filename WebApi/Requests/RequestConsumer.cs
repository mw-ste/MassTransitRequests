using MassTransit;

namespace WebApi.Requests;

public class RequestConsumer : IConsumer<Request>
{
    public async Task Consume(ConsumeContext<Request> context)
    {
        await Task.Delay(1000);
        var request = context.Message;
        await context.RespondAsync(new Response("Query Response"));
    }
}