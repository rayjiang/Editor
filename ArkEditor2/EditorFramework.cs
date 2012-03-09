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

#region Private Field

        [ImportMany]
        IEnumerable<Lazy<IModule>> ImportModules { get; set; }

        Dictionary<string, IModule> m_moduleColletion = new Dictionary<string, IModule>();

#endregion

#region Constructors/Destructors

        public EditorFramework()
        {
            Initialize();
        }

#endregion

#region Private Functions

        private void Initialize()
        {
            var catalog = new AggregateCatalog(new DirectoryCatalog("Modules"));
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);

            // get module interface
            foreach (Lazy<IModule> m in ImportModules)
            {
                m_moduleColletion.Add(m.Value.ModuleName, m.Value);
            }
        }

#endregion

#region Methods

        public string[] GetModuleNames()
        {
            string[] names = new string[m_moduleColletion.Count];

            int index = 0;
            foreach (KeyValuePair<string, IModule> item in m_moduleColletion)
            {
                names[index++] = item.Key;
            }

            return names;
        }

        public IModule GetModuleInterface(string name)
        {
            try
            {
                return m_moduleColletion[name];
            }
            catch (System.Exception)
            {
                return null;
            }
        }

#endregion

    }
}
