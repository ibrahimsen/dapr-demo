using Microsoft.AspNetCore.Mvc;
using Common.Interfaces;

namespace ServiceOne.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private readonly ILogger<MessageController> _logger;
    private readonly IServiceTwoHelper _serviceTwoHelper;


    public MessageController(ILogger<MessageController> logger, IServiceTwoHelper serviceTwoHelper)
    {
        _logger = logger;
        _serviceTwoHelper = serviceTwoHelper;
    }

    [HttpGet(Name = "GetMessage")]
    public string Get()
    {
        return "Service One Message";
    }

    [HttpGet("service-two")]
    public async Task<object> GetServiceTwoAsync()
    {
         var m = await _serviceTwoHelper.GetMessage();

        return m;
    }
}

