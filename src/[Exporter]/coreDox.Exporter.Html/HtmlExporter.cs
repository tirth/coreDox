using coreDox.Core.Contracts;
using coreDox.Core.Model.Project;

namespace coreDox.Exporter.Html
{
    public class HtmlExporter : IExporter<HtmlConfig>
    {
        public void Export(string outputPath)
        {
            
        }

        public DoxProject DoxProject { get; set; }

        public HtmlConfig Config { get; set; }

        public string ExporterName => "Html";
    }
}
