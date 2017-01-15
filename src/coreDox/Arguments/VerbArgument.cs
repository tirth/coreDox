using coreDox.Model;

namespace coreDox.Arguments
{
    public class VerbArgument
    {
        public VerbArgument(string verb)
        {
            Verb = verb;
        }

        public ExitCode ExecuteVerb(string[] args)
        {
            return ExitCode.Success;
        }

        public string Verb { get; }
    }
}