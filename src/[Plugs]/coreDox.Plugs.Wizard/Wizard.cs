using System;
using System.Linq;
using System.Collections.Generic;

using coreDox.Core.Model;
using coreDox.Core.Contracts;

namespace coreDox.Plugs
{
    internal class Wizard : IPlug
    {
        public void Execute(List<PackageFile> packageFiles)
        {
            Console.WriteLine(packageFiles.First().OriginalFilePath);
        }
    }
}