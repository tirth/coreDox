using System;
using Microsoft.Extensions.DependencyInjection;

namespace coreDox.Core.Services
{
    public static class ServiceLocator
    {
        private static IServiceProvider _serviceProvider;

        public static T GetService<T>()
        {
            if(_serviceProvider == null)
            {
                BuildServiceProvider();
            }
            return _serviceProvider.GetService<T>();
        }

        private static void BuildServiceProvider()
        {
            _serviceProvider = new ServiceCollection()
                .AddSingleton<ExporterService>()
                .BuildServiceProvider();
        }
    }
}
