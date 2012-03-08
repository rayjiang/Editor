using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArkEditor2.Interface;
using System.ComponentModel.Composition;

namespace TerrainModule
{
    [Export(typeof(IModule))]
    class TerrainModuleCore : IModule
    {
        public string ModuleName
        {
            get { return "TerrainModule"; }
        }
    }
}
