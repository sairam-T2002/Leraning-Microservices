using Microsoft.AspNetCore.Mvc;

namespace BookingService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingController : ControllerBase
{

    [HttpGet(Name = "Getbooking")]
    public string Getbooking()
    {
        return "from Booking Microservice";
    }
}