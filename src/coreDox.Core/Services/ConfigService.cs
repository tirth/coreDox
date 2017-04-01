using coreDox.Core.Exceptions;
using coreDox.Core.Model.Documentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace coreDox.Core.Services
{
    public class ConfigService
    {
        private List<object> _loadedConfigs = new List<object>();
        private List<Type> _configTypes = new List<Type>();

        private readonly ExporterService _exporterService;

        public ConfigService()
        {
            _exporterService = ServiceLocator.GetService<ExporterService>();
            FindConfigTypes();
        }

        public void LoadConfig(string configPath)
        {
            _loadedConfigs = new List<object>();
        }

        public T GetConfig<T>()
        {
            if (_loadedConfigs.Count == 0) throw new CoreDoxException("No config loaded!");
            return (T)_loadedConfigs.Single(l => l.GetType() == typeof(T));
        }

        private void FindConfigTypes()
        {
            _configTypes.Add(typeof(DoxConfig));
            foreach(var exporterType in _exporterService.RegisteredExporterTypes)
            {
                var exporterInterface = exporterType.GetInterfaces().SingleOrDefault(i => i.Name == "IExporter");
                if(exporterInterface != null)
                {
                    var configType = exporterInterface.GenericTypeArguments.FirstOrDefault();
                    if (configType != null) _configTypes.Add(configType);
                }
            }
        }
    }
}
