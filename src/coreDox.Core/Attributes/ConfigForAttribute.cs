using System;

namespace coreDox.Core.Attributes
{
    public class ConfigForAttribute : Attribute
    {
        public ConfigForAttribute(Type type)
        {
            Type = type;
        }

        public Type Type { get; }
    }
}
