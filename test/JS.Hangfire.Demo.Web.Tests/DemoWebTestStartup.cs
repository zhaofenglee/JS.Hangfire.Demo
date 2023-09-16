using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace JS.Hangfire.Demo;

public class DemoWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<DemoWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
