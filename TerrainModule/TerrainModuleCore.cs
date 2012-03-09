using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using ArkEditor2.Interface;
using System.ComponentModel.Composition;

namespace TerrainModule
{
    [Export(typeof(IModule))]
    class TerrainModuleCore : IModule
    {
        private UI.TerrainEditorForm m_mainForm;

        public string ModuleName
        {
            get { return "TerrainModule"; }
        }

        public string ModuleCaption
        {
            get { return "Terrain Editor"; }
        }

        public string ModuleDescription
        {
            get { return "Edit terrain"; }
        }

        public Image ModuleGlyph
        {
            get { return this.ModuleLargeGlyph; }
        }

        public Image ModuleLargeGlyph
        {
            get { return global::TerrainModule.Properties.Resources.TerrainModule; }
        }

        public Form ModuleForm
        {
            get
            {
                if (m_mainForm == null || m_mainForm.IsDisposed)
                    m_mainForm = new UI.TerrainEditorForm();

                return m_mainForm;
            }
        }
    }
}
