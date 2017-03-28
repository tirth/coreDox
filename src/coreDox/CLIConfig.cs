using coreDox.Core.Contracts;

namespace coreDox
{
    public class CLIConfig : IConfig<CLI>
    {
        public string ProjectName { get; set; }
    }
}
