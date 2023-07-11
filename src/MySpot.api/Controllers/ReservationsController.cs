using System;
using Microsoft.AspNetCore.Mvc;

[Route(template:"reservations")]
public class ReservationController : Controller
{
	[HttpGet(template:"get")]
	public void Get()
	{

	}

    [HttpPost]
    public void Post([FromBody]Reservation reservation)
    {

    }
}


	
