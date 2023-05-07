using Microsoft.AspNetCore.Mvc;

namespace FireApp.Controllers;

[ApiController]
[Route("[controller]")]
public class DriversController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing",
        "Bracing",
        "Chilly",
        "Cool",
        "Mild",
        "Warm",
        "Balmy",
        "Hot",
        "Sweltering",
        "Scorching"
    };

    private readonly ILogger<DriversController> _logger;

    public DriversController(ILogger<DriversController> logger)
    {
        _logger = logger;
    }
}
