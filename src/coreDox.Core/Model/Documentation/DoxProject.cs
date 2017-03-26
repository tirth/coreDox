using System.Collections.Generic;

namespace coreDox.Core.Model.Documentation
{
    /// <summary>
    /// The <c>DoxProject</c> is the root object of a documentation project.
    /// It contains references to all elements in a project.
    /// </summary>
    public class DoxProject
    {
        public void Save()
        {

        }

        /// <summary>
        /// Creates a new documentation project in the given folder.
        /// </summary>
        /// <param name="docFolder">The folder for the new documentation project.</param>
        /// <returns>The created <c>DocProject</c>.</returns>
        public static DoxProject New(string docFolder)
        {
            var doxProject = new DoxProject { DocFolder = docFolder };
            return doxProject;
        }

        /// <summary>
        /// Loads the given documentation project folder.
        /// </summary>
        /// <param name="docFolder">The folder which contains the *coreDox* project.</param>
        /// <returns>The loaded <c>DoxProject</c>.</returns>
        public static DoxProject Load(string docFolder)
        {
            var doxProject = new DoxProject { DocFolder = docFolder };
            return doxProject;
        }

        /// <summary>
        /// The folder containing the documentation project.
        /// </summary>
        public string DocFolder { get; set; }

        /// <summary>
        /// The documentation config.
        /// </summary>
        public DoxConfig Config { get; set; }

        /// <summary>
        /// The table of contents of the documentation.
        /// </summary>
        public DoxTOC TOC { get; set; }

        /// <summary>
        /// All additional pages of the documentation.
        /// </summary>
        public List<DoxPage> DocPages { get; set; }
    }
}
