using System;
using coreDox.Model;

namespace coreDox
{
    public class CLI
    {
        static int Main(string[] args)
        {       
            var exitCode = ExitCode.Success;
            CommandLineArgs commandLineArgs;
            if(CommandLineArgs.TryParse(args, out commandLineArgs))
            {
                exitCode = Execute(commandLineArgs);
            }
            else{
                Console.WriteLine("Couldn't parse arguments. Valid options are:");
                exitCode = ExitCode.InvalidArgs;
            }
            return (int)exitCode;
        }

        private static ExitCode Execute(CommandLineArgs commandLineArgs)
        {
            var exitCode = ExitCode.Success;
            if(commandLineArgs.HelpArgument != null)
            {
                commandLineArgs.HelpArgument.PrintHelp();
            }
            else if(commandLineArgs.VersionArgument != null)
            {
                commandLineArgs.VersionArgument.PrintVersionInfo();
            }
            else if(commandLineArgs.VerbArgument != null)
            {
                exitCode = commandLineArgs.VerbArgument.ExecuteVerb(commandLineArgs.RemainingArgs);
            }
            return exitCode;
        }
    }
}
