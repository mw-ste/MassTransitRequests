using ContextA.Contracts;
using Infrastructure;

namespace ContextA.Infrastructure;

public class ExampleRequestHandler 
    : MassTransitRequestHandler<ExampleRequest, ExampleResponse>
{
    public override Task<ExampleResponse> HandleQuery(ExampleRequest request)
    {
        var response = new ExampleResponse(request.RequestId, string.Join("", request.RequestContent.Reverse()));
        return Task.FromResult(response);
    }
}