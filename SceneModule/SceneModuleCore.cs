using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ArkEditor2.Interface;
using System.ComponentModel.Composition;

namespace SceneModule
{
    [Export(typeof(IModule))]
    class SceneModuleCore : IModule
    {
        public string ModuleName
        {
            get { return "SceneModule"; }
        }
    }
}
