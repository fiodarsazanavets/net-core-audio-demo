using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace NetCoreAudioDemo
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddNodeServices();
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			// Leaving blank. The method is required for building web host, but it's not needed in this app
		}
	}
}
