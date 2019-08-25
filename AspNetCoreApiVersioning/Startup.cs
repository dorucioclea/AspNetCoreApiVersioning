using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreApiVersioning
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void Configure(IApplicationBuilder application, IHostingEnvironment environment)
		{
			if (environment.IsDevelopment())
			{
				application.UseDeveloperExceptionPage();
			}
			else
			{
				application.UseHsts();
			}

			application.UseHttpsRedirection();
			application.UseMvc();
		}

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
	}
}
