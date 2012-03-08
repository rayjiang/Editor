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
        DockPanel m_settings;
        DockPanel m_timeline;
        DockPanel m_channel;

        Stream m_layoutData;

        public FxEditor()
        {
            InitializeComponent();

            // workaround for maximized RibbonForm
            m_dockManager.ForceInitialize();
            mainRibbon.ForceInitialize();
            mainRibbon.Manager.DockManager = m_dockManager;
        }

        private void Close_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FxEditor_Load(object sender, EventArgs e)
        {
        }

        private void SetRootPanelsVisibility(DockVisibility visibility)
        {
            for (int i = m_dockManager.RootPanels.Count - 1; i >= 0; i--)
            {
                DockPanel panel = m_dockManager.RootPanels[i];
                if (panel == null || panel.Dock == DockingStyle.Float)
                    continue;
                if (panel.Count > 0 && !panel.Tabbed)
                {
                    DockPanel lastChild = panel[panel.Count - 1];
                    for (int j = 0; j < panel.Count - 1; j++)
                        panel[j].Visibility = DockVisibility.AutoHide;
                    lastChild.Visibility = DockVisibility.AutoHide;
                }
                else
                    panel.Visibility = visibility;
            }
        }

        private void ShowAllHiddenPanels()
        {
            while (m_dockManager.HiddenPanels.Count > 0)
            {
                m_dockManager.HiddenPanels[0].Visibility = DockVisibility.Visible;
            }
        }

        private DockPanel GetPanelByDockingStyle(DockManager manager, DockingStyle style)
        {
            for (int i = 0; i < manager.RootPanels.Count; i++)
            {
                DockPanel panel = manager.RootPanels[i];
                if (panel == null || panel.Dock == DockingStyle.Float)
                    continue;
                if (panel.Dock == style)
                    return panel;
            }
            return null;
        }

        public void DockToMainForm(DockManager dockManager)
        {
            SetRootPanelsVisibility(DockVisibility.Hidden);

            m_mainDockManager = dockManager;
            m_settings = m_mainDockManager.AddPanel(DockingStyle.Float);
            m_settings.ControlContainer.Controls.Add(ucSetting);
            m_settings.DockTo(DockingStyle.Left, 0);
            m_timeline = m_mainDockManager.AddPanel(DockingStyle.Float);
            m_timeline.ControlContainer.Controls.Add(ucTimeLine);
            DockPanel bottomPanel = GetPanelByDockingStyle(m_mainDockManager, DockingStyle.Bottom);
            if (bottomPanel != null)
                m_timeline.DockAsTab(bottomPanel, 0);
            else
                m_timeline.DockTo(DockingStyle.Bottom);
            m_channel = m_mainDockManager.AddPanel(DockingStyle.Float);
            m_channel.ControlContainer.Controls.Add(ucChannel);
            m_channel.DockAsTab(m_timeline, 1);
        }

        public void UndockFromMainForm()
        {
            dpSettings.ControlContainer.Controls.Add(ucSetting);
            dpTimeLine.ControlContainer.Controls.Add(ucTimeLine);
            dpChannel.ControlContainer.Controls.Add(ucChannel);
            ShowAllHiddenPanels();
            m_mainDockManager.RemovePanel(m_settings);
            m_mainDockManager.RemovePanel(m_timeline);
            m_mainDockManager.RemovePanel(m_channel);
        }

        private void FxEditor_Closed(object sender, FormClosedEventArgs e)
        {
            UndockFromMainForm();
        }
    }
}