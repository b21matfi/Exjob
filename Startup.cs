using Microsoft.Extensions.DependencyInjection;
using Exjob;
using Services;
namespace Services
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<CompileService>();
        }

    }
}
