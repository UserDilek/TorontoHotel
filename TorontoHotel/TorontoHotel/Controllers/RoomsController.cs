using System;
using Microsoft.AspNetCore.Mvc;

namespace TorontoHotel.Controllers
{
	[Route("/[controller]")]
	[ApiController]
	public class RoomsController:ControllerBase
	{
		[HttpGet(Name =nameof(GetRooms))]
		public IActionResult GetRooms()
		{
			throw new Exception();
		}
	}
}

