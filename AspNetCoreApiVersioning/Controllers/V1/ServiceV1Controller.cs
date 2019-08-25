using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApiVersioning.Controllers
{
	[ApiController]
	[ApiVersion("1.0", Deprecated = true)]
	[Route("api/{version:apiVersion}/service")]
	public class ServiceV1Controller : ControllerBase
	{
		[HttpGet]
		public ActionResult<string> Get()
		{
			return nameof(ServiceV1Controller);
		}
	}
}
