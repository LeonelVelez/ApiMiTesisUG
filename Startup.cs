using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiMiTesisUG.Entities.MyBdContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace ApiMiTesisUG
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Api Mi Tesis UG",
                    Description = "Es un servicio web de arquitectura rest full monolitica open source, que funciona como backend de un aplicativo movil universitario. Utilizando tecnología .net",
                    Contact = new OpenApiContact
                    {
                        Name = "Jefferson Leonel Velez",
                        Email = "jefferson.velezl@ug.edu.ec",
                        Url = new Uri("https://github.com/LeonelVelez"),
                    }
                });
            });
        
            services.AddDbContext<MyBdContext>(option => option.UseSqlServer(Configuration.GetValue<string>("Connection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1 API Mi Tesis UG");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
