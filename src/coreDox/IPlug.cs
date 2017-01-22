using System.Collections.Generic;

namespace coreDox
{
    public interface IPlug
    {
        void Execute(List<PackageFile> packageFiles);
    }
}