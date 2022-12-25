using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers (this IServiceCollection serviceCollection,ICoreModule[] coreModules)
        {
            foreach (var model in coreModules)
            {
                model.Load(serviceCollection);
            }

            return ServiceTool.Create(serviceCollection);
        }
    }
}
