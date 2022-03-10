using ContextA.Contracts;
using Infrastructure;
using Microsoft.Extensions.Logging;

namespace ContextA.Infrastructure;

public class ExampleRequestHandler 
    : MassTransitRequestHandler<ExampleRequest, ExampleResponse>
{
    private readonly ILogger<ExampleRequestHandler> _logger;

    public ExampleRequestHandler(ILogger<ExampleRequestHandler> logger)
    {
        _logger = logger;
    }

    public override Task<ExampleResponse> HandleQuery(ExampleRequest request)
    {
        var response = new ExampleResponse(request.RequestId, string.Join("", request.RequestContent.Reverse()));
        return Task.FromResult(response);
    }
}