using coreDox.Core.Model.Project;

namespace coreDox.Core.Contracts
{
    public interface IExporter
    {
        void Export(string outputPath);

        DoxProject DoxProject { get; set; }

        string ExporterName { get; }
    }

    public interface IExporter<TConfig> : IExporter
    {
        TConfig Config { get; set; }
    }
}