namespace WebApi.Controllers;

using ContextA.Contracts;
using Microsoft.AspNetCore.Mvc;
using Shared;

[ApiController]
[Route("[controller]")]
public class RequestsController : ControllerBase
{
    private readonly IRequester<DummyRequest, DummyResponse> _requester;

    public RequestsController(IRequester<DummyRequest, DummyResponse> requester)
    {
        _requester = requester;
    }

    [HttpGet(Name = nameof(Get))]
    public async Task<string> Get()
    {
        var request = new DummyRequest("RequestId", "abcdef");
        var response = await _requester.Get(request);
        return response.ResponseContent;
    }
}
