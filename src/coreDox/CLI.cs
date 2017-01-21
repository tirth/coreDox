using System;
using System.Linq;

using coreArgs;
using coreDox.Model;

namespace coreDox
{
    public class CLI
    {
        static int Main(string[] args)
        {       
            var exitCode = ExitCode.Success;
            var options = ArgsParser.Parse<CommandLineOptions>(args);
            if(options.Errors.Count > 0)
            {
                exitCode = ExitCode.InvalidArgs;
                options.Errors.ForEach(e => Console.WriteLine(e.Message));
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(ArgsParser.GetHelpText<CommandLineOptions>());
            }
            else{
                
            }
            return (int)exitCode;
        }
    }
}
