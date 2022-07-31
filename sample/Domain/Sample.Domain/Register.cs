using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using asm = System.Reflection.Assembly;

namespace Sample.Domain
{
    public static class Register
    {
        public static IServiceCollection AddDomainService(this IServiceCollection services)
        {

            //services.Scan(scan => scan
            //.FromAssemblyOf<Sim.Core.Model.Service>()
            //  .AddClasses(classes => classes.AssignableTo(typeof(Sim.Core.Model.IService)))
            //.AsImplementedInterfaces()
            //.WithTransientLifetime());


            //services.Scan(scan => scan
            //.FromAssemblyOf<Sim.Core.Model.Service>()
            //  .AddClasses(classes => classes.AssignableTo(typeof(Sim.Core.Model.Service)))
            //.AsImplementedInterfaces()
            //.WithTransientLifetime());


            //services.Scan(scan =>
            //  scan.FromAssemblyOf<Sim.Core.Model.Service>()
            //      .AddClasses(classes => classes.AssignableTo<Sim.Core.Model.IService>())
            //      .AsSelf()
            //      .WithTransientLifetime());


            //services.Scan(scan => scan
            //.FromCallingAssembly()
            //  .AddClasses(classes => classes.AssignableTo(typeof(Sim.Core.Model.Service)))
            //.AsImplementedInterfaces()
            //.WithTransientLifetime());

            //var svcInterfaces = asm.GetAssembly(typeof(Sim.Core.Model.IService))
            //              .GetTypes();

            //var svcClasses = asm.GetAssembly(typeof(Sim.Core.Model.Service))
            //                 .GetTypes();
            services.Scan(scan => scan.FromCallingAssembly()                    
            .AddClasses()
            .AsMatchingInterface()
            .WithTransientLifetime());

            //foreach (var s in svcInterfaces)
            //{
            //}
            //foreach (var s in svcClasses)
            //{
            //}
            return services;
        }
    }
}
