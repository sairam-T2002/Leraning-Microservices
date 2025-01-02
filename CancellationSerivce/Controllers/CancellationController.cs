using Microsoft.AspNetCore.Mvc;

namespace CancellationSerivce.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CancellationController : ControllerBase
{

    [HttpGet(Name = "GetCancellation")]
    public string Getbooking()
    {
        return "from Cancellation Microservice";
    }
}
