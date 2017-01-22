using System;
using System.Collections.Generic;

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