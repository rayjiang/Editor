using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ArkEditor2.Interface
{
    public interface IModule
    {
        string ModuleName { get; }
        string ModuleCaption { get; }
        string ModuleDescription { get; }

        Image ModuleGlyph { get; }
        Image ModuleLargeGlyph { get; }

        Form ModuleForm { get; }
    }
}
