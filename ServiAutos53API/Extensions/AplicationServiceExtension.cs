using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Task;

namespace ServiAutos53API;

public static class ApplicationServiceExtension
{

    public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options =>
    
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        }

    );

}