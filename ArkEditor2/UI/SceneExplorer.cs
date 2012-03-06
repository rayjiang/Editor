using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ArkEditor2.UI
{
    public partial class SceneExplorer : DevExpress.XtraEditors.XtraUserControl
    {
        public SceneExplorer()
        {
            InitializeComponent();
        }

        private void SceneExplorer_Load(object sender, EventArgs e)
        {
            treeList1.ExpandAll();
        }
    }
}
