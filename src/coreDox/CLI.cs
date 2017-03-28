using CommandLine;

using coreDox.Build;
using coreDox.New;
using coreDox.Watch;
using coreDox.Core.Model;

namespace coreDox
{
    public class CLI
    {
        static int Main(string[] args)
        {
            var exitCode = ExitCode.Success;
            
            Parser.Default.ParseArguments<NewOptions, BuildOptions, WatchOptions>(args)
                .WithParsed<NewOptions>(opts => new NewVerb(opts))
                .WithParsed<BuildOptions>(opts => new BuildVerb(opts))
                .WithParsed<WatchOptions>(opts => new WatchVerb(opts))
                .WithNotParsed(errs => {
                    exitCode = ExitCode.InvalidArgs;                    
                });

            return (int)exitCode;
        }
    }
}
