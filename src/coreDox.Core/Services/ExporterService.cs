using coreDox.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace coreDox.Core.Services
{
    public class ExporterService
    {
        private readonly PluginDiscoveryService _pluginDiscoveryService;

        public ExporterService()
        {
            _pluginDiscoveryService = ServiceLocator.GetService<PluginDiscoveryService>();
            RegisteredExporter = _pluginDiscoveryService.GetAllExporterPlugins();
            RegisteredExporterTypes = RegisteredExporter.Select(r => r.GetType()).ToList();
        }

        public List<IExporter> RegisteredExporter { get; }
        public List<Type> RegisteredExporterTypes { get; }
    }
}
