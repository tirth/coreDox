using coreDox.Core.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace coreDox.Core.Services
{
    public class ExporterService
    {
        public readonly string _exporterFolder = 
            Path.Combine(Path.GetDirectoryName(typeof(ExporterService).GetTypeInfo().Assembly.Location), "Exporter");

        public List<IExporter> GetRegisteredExporters()
        {
            var exporter = new List<IExporter>();

            var possibleExporterDllFiles = Directory.GetFiles(_exporterFolder, "*.dll", SearchOption.AllDirectories);
            foreach(var possibleExporterDllFile in possibleExporterDllFiles)
            {
                var possibleExporterAssembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(possibleExporterDllFile);
                var exporterTypes = possibleExporterAssembly.GetTypes().Where(t => t.GetInterfaces().Any(i => i.Name == "IExporter")).ToList();
                exporterTypes.ForEach(e => exporter.Add((IExporter)Activator.CreateInstance(e)));
            }

            return exporter;
        }
    }
}
