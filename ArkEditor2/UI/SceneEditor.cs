using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;

namespace ArkEditor2.UI
{
    public partial class SceneEditor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DockPanel m_plExplorer;
        private DockPanel m_plProperty;
        DockManager m_dockManager;

        public SceneEditor()
        {
            InitializeComponent();
        }

        public void DockToMainForm(DockManager dockManager)
        {
            m_dockManager = dockManager;

            SceneExplorer sceneExplorer = new SceneExplorer();
            sceneExplorer.Dock = DockStyle.Fill;

            ObjectProperty objProperty = new ObjectProperty();
            objProperty.Dock = DockStyle.Fill;

            m_plExplorer = dockManager.AddPanel(DockingStyle.Float);
            m_plExplorer.Text = "Scene Explorer";
            m_plExplorer.ControlContainer.Controls.Add(sceneExplorer);
            m_plExplorer.DockTo(DockingStyle.Left, 0);

            m_plProperty = dockManager.AddPanel(DockingStyle.Float);
            m_plProperty.Text = "Object Property";
            m_plProperty.ControlContainer.Controls.Add(objProperty);
            m_plProperty.DockTo(DockingStyle.Right, 0);
        }

        public void UndockFromMainForm()
        {
            m_dockManager.RemovePanel(m_plExplorer);
            m_dockManager.RemovePanel(m_plProperty);
        }

        private void SceneExplorer_Closed(object sender, FormClosedEventArgs e)
        {
            UndockFromMainForm();
        }

        private void Close_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}