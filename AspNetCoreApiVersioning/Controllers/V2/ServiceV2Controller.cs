using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApiVersioning.Controllers
{
	[ApiController]
	[ApiVersion("2.0")]
	[Route("api/{version:apiVersion}/service")]
	public class ServiceV2Controller : ControllerBase
	{
		[HttpGet]
		public ActionResult<string> Get()
		{
			return nameof(ServiceV2Controller);
		}
	}
}