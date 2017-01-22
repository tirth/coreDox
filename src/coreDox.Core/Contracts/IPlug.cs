using System.Collections.Generic;

using coreDox.Core.Model;

namespace coreDox.Core.Contracts
{
    public interface IPlug
    {
        void Execute(List<PackageFile> packageFiles);
    }
}