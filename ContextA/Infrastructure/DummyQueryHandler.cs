using ContextA.Contracts;
using Infrastructure;

namespace ContextA.Infrastructure;

public class DummyQueryHandler : MassTransitRequestHandler<DummyRequest, DummyResponse>
{
    public override Task<DummyResponse> HandleQuery(DummyRequest request)
    {
        var response = new DummyResponse(request.RequestId, string.Join("", request.RequestContent.Reverse()));
        return Task.FromResult(response);
    }
}