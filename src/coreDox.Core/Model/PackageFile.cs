using System.IO;

namespace coreDox.Core.Model
{
    public class PackageFile
    {
        public PackageFile(string filePath)
        {
            OriginalFilePath = filePath;
            OriginalFileExtension = Path.GetExtension(filePath);
            OriginalFileContent = File.ReadAllText(filePath);
            FileContent = OriginalFileContent;
        }

        public string OriginalFilePath { get; }

        public string OriginalFileExtension { get; }

        public string OriginalFileContent { get; }

        public string FileContent { get; set; }
    }
}