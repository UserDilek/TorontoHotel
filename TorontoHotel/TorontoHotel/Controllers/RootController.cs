using System;
using Microsoft.AspNetCore.Mvc;

namespace TorontoHotel.Controllers
{
	[Route("/")]
	[ApiController]
	public class RootController : Controller
	{
		[HttpGet(Name =nameof(GetRoot))]
		public IActionResult GetRoot()
		{
			var response = new
			{
				href = Url.Link(nameof(GetRoot),null),
				room = new
				{
                    href = Url.Link(nameof(RoomsController.GetRooms), null),
                }
				
		   }; 
			return Ok(response);

        }
	}
}

