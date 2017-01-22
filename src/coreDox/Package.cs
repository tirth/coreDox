using System.IO;
using System.Collections.Generic;

namespace coreDox
{
    public class Package
    {
        public Package(){ }

        public Package(string filePattern)
        {
            FilePattern = filePattern;
            LoadFiles();
        }

        public Package(string folder, string filePattern)
        {
            Folder = folder;
            FilePattern = filePattern;
            LoadFiles();
        }

        public Package Plug(IPlug plug)
        {
            plug.Execute(PackageFiles);
            return this;
        }

        private void LoadFiles()
        {
            var allFiles = Directory.GetFiles(Folder, FilePattern, SearchOption.AllDirectories);
            foreach(var file in allFiles)
            {
                var packageFile = new PackageFile(file);
                PackageFiles.Add(packageFile);
            }
        }

        public string Folder { get; }

        public string FilePattern { get; }

        public List<PackageFile> PackageFiles { get; } = new List<PackageFile>();
    }
}