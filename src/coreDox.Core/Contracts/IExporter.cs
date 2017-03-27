namespace coreDox.Core.Contracts
{
    public interface IExporter
    {
        void Export();

        string ExporterName { get; }
    }
}