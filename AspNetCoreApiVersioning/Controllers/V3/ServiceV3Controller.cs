using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApiVersioning.Controllers
{
	[ApiController]
	[ApiVersion("3.0")]
	[Route("api/{version:apiVersion}/service")]
	public class ServiceV3Controller : ControllerBase
	{
		[HttpGet]
		public ActionResult<string> Get()
		{
			return nameof(ServiceV3Controller);
		}
	}
}
