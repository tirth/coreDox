using coreDox.Core.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace coreDox.Core.Services
{
    public class ConfigService
    {
        private readonly PluginDiscoveryService _pluginDiscoveryService;

        public ConfigService()
        {
            _pluginDiscoveryService = ServiceLocator.GetService<PluginDiscoveryService>();
            RegisteredConfigs = _pluginDiscoveryService.GetAllConfigPlugins();
        }

        public void RegisterConfig<T>(T config) where T : IConfig
        {
            RegisteredConfigs.Add(config);
        }

        public IConfig<T> GetConfig<T>()
        {
            return (IConfig<T>)RegisteredConfigs.Single(e => e.GetType().GetInterfaces().Where(i => i.GenericTypeArguments.Any(g => g == typeof(T))) != null);
        }
         
        public List<IConfig> RegisteredConfigs { get; }
    }
}
