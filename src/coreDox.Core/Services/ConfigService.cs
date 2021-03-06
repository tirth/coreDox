﻿using coreDox.Core.Model.Project;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace coreDox.Core.Services
{
    /// <summary>
    /// This service is responsible to load config files and to deliver certain sections in these files.
    /// </summary>
    public class ConfigService
    {
        private List<Type> _configTypes = new List<Type>();

        private readonly ExporterService _exporterService;

        /// <summary>
        /// The <c>ConfigService</c> uses the <seealso cref="ExporterService"/> to get all available <seealso cref="Contracts.IExporter{TConfig}"/>.
        /// </summary>
        public ConfigService()
        {
            _exporterService = ServiceLocator.GetService<ExporterService>();
            FindConfigTypes();
        }
        
        /// <summary>
        /// Return the loaded config section for the given config type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of the config section</typeparam>
        /// <returns>A instance of the config type with the loaded config values</returns>
        /// <remarks><see cref="LoadConfig(string)"/> has to be executed in advance!</remarks>
        public T GetConfig<T>(string configPath)
        {
            var configSections = LoadConfig(configPath);
            return (T)configSections.Single(l => l.GetType() == typeof(T));
        }

        /// <summary>
        /// Loads the given config file into the found config types.
        /// The generic type paramter of the <seealso cref="Contracts.IExporter{TConfig}"/> is the config type used by a exporter.
        /// The name of the config type is the key of the section in the config file.
        /// </summary>
        /// <param name="configPath">The config file to load</param>
        private List<object> LoadConfig(string configPath)
        {
            var configSections = new List<object>();

            var converter = new ExpandoObjectConverter();
            var jsonConfig = JsonConvert.DeserializeObject<ExpandoObject>(File.ReadAllText(configPath), converter);
            foreach (var config in jsonConfig)
            {
                var configType = _configTypes.SingleOrDefault(c => c.Name.Equals(config.Key, StringComparison.OrdinalIgnoreCase));
                if (configType != null)
                {
                    var serializedSubConfig = JsonConvert.SerializeObject(config.Value);
                    configSections.Add(JsonConvert.DeserializeObject(serializedSubConfig, configType));
                }
            }
            return configSections;
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
