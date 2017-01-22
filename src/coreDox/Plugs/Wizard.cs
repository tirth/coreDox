using System;
using System.Linq;
using System.Collections.Generic;

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