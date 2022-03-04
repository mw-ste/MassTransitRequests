using MassTransit;

namespace WebApi.Requests;

public class RequestConsumer : IConsumer<Request>
{
    public async Task Consume(ConsumeContext<Request> context)
    {
        await Task.Delay(1000);
        var request = context.Message;
        context.RespondAsync<Response>(new Response("Query Response"));
    }
}