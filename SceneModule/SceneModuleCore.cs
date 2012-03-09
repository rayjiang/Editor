using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using ArkEditor2.Interface;
using System.ComponentModel.Composition;

namespace SceneModule
{
    [Export(typeof(IModule))]
    class SceneModuleCore : IModule
    {
        private UI.SceneEditorForm m_mainForm;

        public string ModuleName
        {
            get { return "SceneModule"; }
        }

        public string ModuleCaption
        {
            get { return "Scene Editor"; }
        }

        public string ModuleDescription
        {
            get { return "Build scene"; }
        }

        public Image ModuleGlyph
        {
            get { return this.ModuleLargeGlyph; }
        }

        public Image ModuleLargeGlyph
        {
            get { return global::SceneModule.Properties.Resources.SceneModule; }
        }

        public Form ModuleForm
        {
            get 
            {
                if (m_mainForm == null || m_mainForm.IsDisposed)
                    m_mainForm = new UI.SceneEditorForm();

                return m_mainForm;
            }
        }
    }
}
