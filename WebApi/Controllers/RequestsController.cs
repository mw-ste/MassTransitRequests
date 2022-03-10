namespace WebApi.Controllers;

using ContextA.Contracts;
using Microsoft.AspNetCore.Mvc;
using Shared;

[ApiController]
[Route("[controller]")]
public class RequestsController : ControllerBase
{
    private readonly IRequester<ExampleRequest, ExampleResponse> _requester;

    public RequestsController(IRequester<ExampleRequest, ExampleResponse> requester)
    {
        _requester = requester;
    }

    [HttpGet(Name = nameof(Get))]
    public async Task<string> Get()
    {
        var request = new ExampleRequest("RequestId", "abcdef");
        var response = await _requester.Get(request);
        return response.ResponseContent;
    }
}
