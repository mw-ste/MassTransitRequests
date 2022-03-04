namespace WebApi.Controllers;

using MassTransit;
using Microsoft.AspNetCore.Mvc;
using WebApi.Requests;

[ApiController]
[Route("[controller]")]
public class RequestsController : ControllerBase
{
    IRequestClient<Request> _requestClient;

    public RequestsController(IRequestClient<Request> requestClient)
    {
        _requestClient = requestClient;
    }

    [HttpGet(Name = nameof(Get))]
    public async Task<string> Get()
    {
        var response = await _requestClient.GetResponse<WebApi.Requests.Response>(new Request(123));
        return response.Message.ResponseString;

        // return "hardcoded string";
    }
}
