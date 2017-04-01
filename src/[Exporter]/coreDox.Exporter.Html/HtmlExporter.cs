using coreDox.Core.Contracts;
using coreDox.Core.Model.Documentation;

namespace coreDox.Exporter.Html
{
    public class HtmlExporter : IExporter<HtmlConfig>
    {
        public void Export(string outputPath)
        {
            
        }

        public DoxProject DoxProject { get; set; }

        public HtmlConfig HtmlConfig { get; set; }

        public string ExporterName => "Html";
    }
}
