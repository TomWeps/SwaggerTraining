using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using Microsoft.AspNetCore.Builder;

namespace TodoApi.Configuration
{
    public static class SetupSwagger
    {
        private const string apiVersion = "v1";

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(apiVersion, new Info
                {
                    Version = apiVersion,
                    Title = "ToDo API",
                    Description = "A simple example ASP.NET Core Web API which is using Swagger",
                    Contact = new Contact
                    {
                        Name = "Tomasz Weps",
                        Email = "tomasz.weps@kldiscovery.com"                        
                    }
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

                // Some of additional settings 

                // Enums -> as strings, not int
                c.DescribeAllEnumsAsStrings();

            });
        }

        public static void ConfigureSwagger(this IApplicationBuilder app)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/{apiVersion}/swagger.json", $"ToDo API {apiVersion}");
                c.ShowExtensions();
            });
        }
    }
}
