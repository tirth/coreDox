using System;
using System.Collections.Generic;

namespace coreDox.Core.Services
{
    public class ExporterService
    {
        private readonly PluginDiscoveryService _pluginDiscoveryService;

        public ExporterService()
        {
            _pluginDiscoveryService = ServiceLocator.GetService<PluginDiscoveryService>();
            RegisteredExporterTypes = _pluginDiscoveryService.GetAllExporterPlugins();
        }
        
        public List<Type> RegisteredExporterTypes { get; }
    }
}
