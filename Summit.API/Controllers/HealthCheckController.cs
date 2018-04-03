using Microsoft.AspNetCore.Mvc;

namespace Summit.API.Controllers
{
	[Route("api/[controller]")]
	public class HealthCheckController : Controller
	{
		[HttpGet]
		public string Ping()
		{
			return "OK";
		}
	}
}
