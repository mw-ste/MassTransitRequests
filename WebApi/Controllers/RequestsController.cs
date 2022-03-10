using ContextA.Contracts;

namespace WebApi.Controllers;

using Shared;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class RequestsController : ControllerBase
{
    private readonly IRequestClient<DummyRequest> _requestClient;

    public RequestsController(IRequestClient<DummyRequest> requestClient)
    {
        _requestClient = requestClient;
    }

    [HttpGet(Name = nameof(Get))]
    public async Task<string> Get()
    {
        var response = await _requestClient.GetResponse<DummyResponse>(new DummyRequest("RequestId", "abcdef"));
        return response.Message.ResponseContent;
        //return "hardcoded string";
    }
}
