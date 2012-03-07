using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;

namespace ArkEditor2.UI
{
    public partial class FxEditor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DockManager m_mainDockManager;
        Stream m_layoutData = new MemoryStream();

        public FxEditor()
        {
            InitializeComponent();
        }

        private void Close_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FxEditor_Load(object sender, EventArgs e)
        {
            // workaround for maximized RibbonForm
            m_dockManager.ForceInitialize();
            mainRibbon.ForceInitialize();
            mainRibbon.Manager.DockManager = m_dockManager;
        }

        public void DockToMainForm(DockManager dockManager)
        {
            // save dock panel layout
            //m_dockManager.SaveLayoutToStream(m_layoutData);
            //m_layoutData.Seek(0, SeekOrigin.Begin);

            dpSettings.Hide();
            //dpChannel.Visibility = DockVisibility.Hidden;
            //dpTimeLine.Visibility = DockVisibility.Hidden;

            //m_mainDockManager = dockManager;

            //SceneExplorer sceneExplorer = new SceneExplorer();
            //sceneExplorer.Dock = DockStyle.Fill;

            //ObjectProperty objProperty = new ObjectProperty();
            //objProperty.Dock = DockStyle.Fill;

            //m_plExplorer = dockManager.AddPanel(DockingStyle.Float);
            //m_plExplorer.Text = "Scene Explorer";
            //m_plExplorer.ControlContainer.Controls.Add(sceneExplorer);
            //m_plExplorer.Size = new Size(230, 400);
            //m_plExplorer.ImageIndex = 14;
            //m_plExplorer.DockTo(DockingStyle.Left, 0);

            //m_plProperty = dockManager.AddPanel(DockingStyle.Float);
            //m_plProperty.Text = "Object Property";
            //m_plProperty.ControlContainer.Controls.Add(objProperty);
            //m_plProperty.Size = new Size(260, 400);
            //m_plProperty.ImageIndex = 0;
            //m_plProperty.DockTo(DockingStyle.Right, 0);
        }

        public void UndockFromMainForm()
        {
            //m_dockManager.RemovePanel(m_plExplorer);
            //m_dockManager.RemovePanel(m_plProperty);

            //m_dockManager.RestoreLayoutFromStream(m_layoutData);
            //m_layoutData.Seek(0, SeekOrigin.Begin);
        }
    }
}