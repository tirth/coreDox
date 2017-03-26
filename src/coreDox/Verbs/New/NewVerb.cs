using NLog;

namespace coreDox.New
{
    internal class NewVerb
    {
        public ILogger _logger = LogManager.GetLogger("NewVerb");

        public NewVerb(NewOptions newOptions)
        {
            if(!string.IsNullOrEmpty(newOptions.Exporter))
            {
                
            }
            else
            {
                _logger.Info($"Creating a new project in folder '{newOptions.DocFolder}' ...");
                _logger.Info("Project created successfully!");
            }
        }
    }
}
