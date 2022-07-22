using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sample.Model.Data;
using Sample.Domain;
using Sample.Data.SqlCommands;
using Sample.Data.SqlQueries;
using Sim.Helper;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Sample.Api
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sample.Api", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        Array.Empty<string>()
                    }
                });
            });


            RegisterLibrary(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sample.Api v1"));
            }
            app.UseExceptionHandler(
               options =>
               {
                   options.Run(
                       async context =>
                       {
                           var e = context.Features.Get<IExceptionHandlerFeature>();
                           if (e != null)
                           {
                               if (e.Error is SimException)
                               {
                                   context.Response.ContentType = context.Request.ContentType != null ? context.Request.ContentType : "application/json";
                                   SimException ex = (SimException)e.Error;
                                   context.Response.StatusCode = 200;
                                   var err = Sim.Core.Model.Result.Failure(message: ex.Message, code: (int)ex.Status);
                                 
                                   //var json = Newtonsoft.Json.JsonConvert.SerializeObject(err);
                                   var settings = new Newtonsoft.Json.JsonSerializerSettings();
                                   settings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();
                                   var json = Newtonsoft.Json.JsonConvert.SerializeObject( err, Newtonsoft.Json.Formatting.Indented, settings);
                                   await context.Response.WriteAsync(json).ConfigureAwait(false);
                               }
                               else
                               {
                                   context.Response.ContentType = "text/html";
                                   await context.Response.WriteAsync(e.Error.Message !=null ? e.Error.Message: "undefined error").ConfigureAwait(false);
                               }
                           }
                       });
               }
           );
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void RegisterLibrary(IServiceCollection services)
        {
            services.AddHelperService();
            services.AddDbService(Configuration);
            services.AddDomainService();
            services.AddSqlCommandService();
            services.AddSqlQueriesService();

            services.AddSingleton(services);
            ServiceProviderFactory.SetServiceProvider(services.BuildServiceProvider());

            //services.Decorate<Sim.Core.Connector.IMapService, AutoMapperPg>();

            var serviceProvider = services.BuildServiceProvider();
            var foo = ServiceProviderFactory.GetInstance<Sim.Core.Connector.IMapService>();
            var fo2o = ServiceProviderFactory.GetInstance<IServiceC>();

            var _mapService = serviceProvider.GetRequiredService<Sim.Core.Connector.IMapService>();

            Student2 s = new Student2 { FirstName = "dd", LastName = "ww", NationalCode = "123" };
            var t = _mapService.Map<Student1, Student2>(s);
            t.NationalCode = "135";

        }
    }
    public interface IServiceC
    {
    }

    public class Student1 : Sample.Model.Dto.Model
    {
        public Student1() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public DateTime Date { get; set; }
    }

    public class Student2 : Sample.Model.Dto.Model
    {
        public Student2() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public DateTime Date { get; set; }
    }
}
