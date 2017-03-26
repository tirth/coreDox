using CommandLine;

using coreDox.Build;
using coreDox.New;
using coreDox.Watch;
using coreDox.Core.Model;
using NLog;

namespace coreDox
{
    public class CLI
    {
        static int Main(string[] args)
        {       
            var exitCode = ExitCode.Success;
            
            var logger = LogManager.GetLogger("CLI");
            logger.Info("This is a test of the emergency broadcast system.");
            logger.Warn("This is a test of the emergency broadcast system.");

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
