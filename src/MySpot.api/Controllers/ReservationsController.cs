using System;
using Microsoft.AspNetCore.Mvc;

[ApiController]

[Route(template:"reservations")]
public class ReservationController : Controller
{
    private int _id = 1;
    private readonly List<Reservation> reservations = new();
    private readonly List<string> _parkingSpotNames = new()
    {
        "P1", "P2","P3", "P4"
    };

	[HttpGet]
	public void Get()
	{
        
    }

    [HttpPost]
    public void Post(Reservation reservation)
    {
        if (_parkingSpotNames.All(x => x != reservation.ParkingSpotNAme))
        {
            HttpContext.Response.StatusCode = 400;
            return;
        }

        reservation.Id = _id;
        reservation.Date = DateTime.UtcNow.AddDays(1).Date;
        _id++;
        
    }
}


	
