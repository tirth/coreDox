using coreDox.Core.Contracts;
using System.Collections.Generic;

namespace coreDox.Core.Services
{
    public class ExporterService
    {
        private readonly PluginDiscoveryService _pluginDiscoveryService;

        public ExporterService()
        {
            _pluginDiscoveryService = ServiceLocator.GetService<PluginDiscoveryService>();
            RegisteredExporter = _pluginDiscoveryService.GetAllExporterPlugins();
        }

        public List<IExporter> RegisteredExporter { get; }
    }
}
