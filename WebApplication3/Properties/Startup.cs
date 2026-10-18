using Asp.Versioning;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Win32;

namespace WebApplication3.Properties
{
    public class Startup
    {
        public void ConfigureServices ( IServiceCollection services )
        {
            services.AddControllers ();
            services.AddApiVersioning (static options =>
            {
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion (
                    1,
                    0);
            });
        }
    }
}
