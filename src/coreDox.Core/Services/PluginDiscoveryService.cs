using coreDox.Core.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace coreDox.Core.Services
{
    public class PluginDiscoveryService
    {
        private readonly string[] _possibleExporterDllFiles;
        private readonly string _exporterFolder = Path.Combine(Path.GetDirectoryName(typeof(ExporterService).GetTypeInfo().Assembly.Location), "Exporter");
        
        public PluginDiscoveryService()
        {
            _possibleExporterDllFiles = Directory.GetFiles(_exporterFolder, "*.dll", SearchOption.AllDirectories);
        }

        public List<IConfig> GetAllConfigPlugins()
        {
            var configs = new List<IConfig>();

            foreach (var possibleExporterDllFile in _possibleExporterDllFiles)
            {
                var possibleExporterAssembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(possibleExporterDllFile);
                configs.AddRange(GetTypesWithInterface<IConfig>(possibleExporterAssembly));
            }

            return configs;
        }

        public List<IExporter> GetAllExporterPlugins()
        {
            var exporter = new List<IExporter>();
            
            foreach (var possibleExporterDllFile in _possibleExporterDllFiles)
            {
                var possibleExporterAssembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(possibleExporterDllFile);
                exporter.AddRange(GetTypesWithInterface<IExporter>(possibleExporterAssembly));
            }

            return exporter;
        }

        private List<T> GetTypesWithInterface<T>(Assembly assembly)
        {
            return assembly.GetTypes()
                .Where(t => t.GetInterfaces().Any(i => i == typeof(T)))
                .Select(t => (T)Activator.CreateInstance(t))
                .ToList();
        }
    }
}
