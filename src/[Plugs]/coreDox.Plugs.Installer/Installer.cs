using System;
using System.Collections.Generic;

using coreDox.Core.Model;
using coreDox.Core.Contracts;

namespace coreDox.Plugs
{
    public class Installer : IPlug
    {
        private readonly string _scaffoldName;

        public Installer(string scaffoldName)
        {
            _scaffoldName = scaffoldName;
        }

        public void Execute(List<PackageFile> packageFiles)
        {
            throw new NotImplementedException();
        }
    }
}