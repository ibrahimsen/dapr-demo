using Microsoft.AspNetCore.Mvc;

namespace ServiceTwo.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private readonly ILogger<MessageController> _logger;

    public MessageController(ILogger<MessageController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetMessage")]
    public object Get()
    {
        return new { message = "Service Two Message" };
    }
}

