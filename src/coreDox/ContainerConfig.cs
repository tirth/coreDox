using System;
using Autofac;
using System.IO;
using System.Reflection;

namespace coreDox
{
    public class ContainerConfig
    {
        private IContainer _container;

        private readonly ContainerBuilder _containerBuilder;

        public ContainerConfig()
        {
            _containerBuilder = new ContainerBuilder();
            RegisterDefaultComponents();
        }

        public IContainer BuildContainer()
        {
            return _container ?? (_container = _containerBuilder.Build());
        }

        private void RegisterDefaultComponents()
        {
            
        }
    }
}