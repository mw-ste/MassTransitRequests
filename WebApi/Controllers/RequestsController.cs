using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RequestsController : ControllerBase
{
    [HttpGet(Name = nameof(Get))]
    public string Get()
    {
        return "hardcoded string";
    }
}
