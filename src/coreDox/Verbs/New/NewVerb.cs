using coreDox.Core.Model.Project;
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
                _logger.Info($"Adding '{newOptions.Exporter}' to project in folder '{newOptions.DocFolder}' ...");

                var doxProject = DoxProject.Load(newOptions.DocFolder);
                doxProject.Save();

                _logger.Info("Exporter added successfully!");
            }
            else
            {
                _logger.Info($"Creating a new project in folder '{newOptions.DocFolder}' ...");

                DoxProject.New(newOptions.DocFolder);

                _logger.Info("Project created successfully!");
            }
        }
    }
}
