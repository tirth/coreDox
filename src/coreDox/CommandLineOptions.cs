using CommandLine;
using CommandLine.Text;

namespace coreDox
{
    [Verb("new", HelpText = "Create a new coreDox project.")]
    class NewOptions 
    {
    }

    [Verb("build", HelpText = "Build the coreDox project in the current or given directory.")]
    class BuildOptions 
    {
    }
    
    [Verb("watch", HelpText = "Builds and watches the coreDox project in the current or given directory.")]
    class WatchOptions 
    {
    }
}