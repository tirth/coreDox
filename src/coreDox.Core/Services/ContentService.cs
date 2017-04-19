using coreDox.Core.Model.Project;
using System.Collections.Generic;

namespace coreDox.Core.Services
{
    public class ContentService
    {
        public DoxTOC LoadTOC(string tocFilePath)
        {
            var toc = new DoxTOC();
            return toc;
        }

        public List<DoxPage> LoadPages(string pagesFolderPath)
        {
            var docPages = new List<DoxPage>();
            return docPages;
        }
    }
}
