using System.Collections.Generic;

using coreArgs.Attributes;

namespace coreDox
{
    public class CommandLineOptions
    {
        [Option('h', "help", "Prints this help text.")]
        public bool Help { get; set; }

        [Option("scaffolds", "Prints all available scaffolds.")]
        public bool Scaffold { get; set; }

        [RemainingOptions]
        public dynamic PlugOptions { get; set; }

        [BinOptions]
        public List<string> Tasks { get; set; }
    }
}