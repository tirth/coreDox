using coreDox.Core.Contracts;
using coreDox.Core.Model.Project;
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

        public void ExportDocumentation(DoxProject doxProject)
        {
            foreach(var exporterType in RegisteredExporterTypes)
            {
                var exporter = (IExporter) Activator.CreateInstance(exporterType);
                exporter.Export(doxProject.Config.OutputFolder);
            }
        }
        
        public List<Type> RegisteredExporterTypes { get; }
    }
}
