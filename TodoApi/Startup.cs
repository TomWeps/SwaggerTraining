using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoApi.Models;
using TodoApi.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TodoApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TodoContext>(opt =>
                opt.UseInMemoryDatabase("TodoList"));

            services.AddMvc(mvcOptions =>
            {
                mvcOptions.Filters.Add(new ProducesAttribute("application/json"));                
            })
            .AddJsonOptions(jsonOptions =>
            {
                jsonOptions.SerializerSettings.Converters.Add(new StringEnumConverter());
                jsonOptions.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

             services.ConfigureSwagger();
        }
             
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();            
            app.ConfigureSwagger();
            app.UseMvc();
        }
      
    }
}
