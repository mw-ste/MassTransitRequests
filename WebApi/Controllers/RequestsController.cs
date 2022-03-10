using ContextA.Contracts;
using Microsoft.AspNetCore.Mvc;
using Shared;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RequestsController : ControllerBase
{
    private readonly IRequester<ExampleRequest, ExampleResponse> _requester;
    private readonly ILogger<RequestsController> _logger;

    public RequestsController(
        IRequester<ExampleRequest, ExampleResponse> requester,
        ILogger<RequestsController> logger)
    {
        _requester = requester;
        _logger = logger;
    }

    [HttpGet(Name = nameof(Get))]
    public async Task<string> Get()
    {
        var request = new ExampleRequest("RequestId", "abcdef");
        var response = await _requester.Get(request);
        return response.ResponseContent;
    }
}
