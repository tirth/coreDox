using System.Linq;
using coreDox.Arguments;

namespace coreDox
{
    public class CommandLineArgs
    {
        public static bool TryParse(string[] args, out CommandLineArgs commandLineArgs)
        {
            var success = false;
            commandLineArgs = new CommandLineArgs();
            
            if(args.Length == 0) return success;
            switch(args[0])
            {
                case "--help":
                case "-h":
                    commandLineArgs.HelpArgument = new HelpArgument();
                    success = true;
                    break;
                case "--version":
                case "-v":
                    commandLineArgs.VersionArgument = new VersionArgument();
                    success = true;
                    break;
                default:
                    if(!args[0].StartsWith("-"))
                    {
                        commandLineArgs.VerbArgument = new VerbArgument(args[0]);
                        commandLineArgs.RemainingArgs = args.Skip(1).ToArray();
                        success = true;
                    }
                    break;
            }  
            return success;
        }

        public VerbArgument VerbArgument { get; private set; }

        public HelpArgument HelpArgument { get; private set; }

        public VersionArgument VersionArgument { get; private set; }

        public string[] RemainingArgs { get; private set; }
    }
}
