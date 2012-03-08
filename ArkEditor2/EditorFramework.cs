using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using ArkEditor2.Interface;

namespace ArkEditor2
{
    class EditorFramework
    {
        [ImportMany]
        IEnumerable<Lazy<IModule>> m_modules;

        public void Initialize()
        {
            var catalog = new AggregateCatalog(new DirectoryCatalog("Modules"));
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);
        }

        public void InitModules()
        {
            foreach (Lazy<IModule> m in m_modules)
            {
                //MessageBox.Show(m.Value.ModuleName);
            }
        }
    }
}
