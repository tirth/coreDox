using coreDox.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreDox.Core.Model.Documentation
{
    public class DoxConfig : IConfig<DoxProject>
    {
        public string ProjectName { get; set; }
    }
}
