# AspNetCoreApiVersioning

API Versioning in ASP.NET Core.

## API Versioning

[Microsoft Documentation](https://github.com/Microsoft/aspnet-api-versioning/wiki/How-to-Version-Your-Service)

## Nuget Package

Microsoft.AspNetCore.Mvc.Versioning

## Startup.cs

 ```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc();

    services.AddApiVersioning(options =>
    {
        options.ReportApiVersions = true;
        options.AssumeDefaultVersionWhenUnspecified = true;
        options.DefaultApiVersion = new ApiVersion(3, 0);
    });
}
 ```

## ServiceV1Controller.cs

 ```csharp
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
 ```

## ServiceV2Controller.cs

 ```csharp
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
 ```

## ServiceV3Controller.cs

 ```csharp
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
 ```

## URLs

* http://localhost/api/1.0/service
* http://localhost/api/2.0/service
* http://localhost/api/3.0/service

## Response Headers

* api-deprecated-versions: 1.0
* api-supported-versions: 2.0, 3.0
