﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Docking2010.Views;

namespace ArkEditor2.UI
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private BaseDocument m_startPage;
        private BaseDocument m_config;
        private BaseDocument m_revisionLog;
        private SceneEditor m_sceneEditor;

        public MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
        }

        private void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
            SkinHelper.InitSkinPopupMenu(pmSkins);
        }

        private void AppearancePageGroup_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            pmSkins.ShowPopup(mainRibbon.Manager, MousePosition);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Merge Style
            this.mainRibbon.MdiMergeStyle = RibbonMdiMergeStyle.Always;

            // Init Gallery
            InitModuleGallery(moduleGallery.Gallery.Groups[0]);
            InitToolsGallery(toolGallery.Gallery.Groups[0]);

            // Init Tabbed View
            tabbedView.BeginUpdate();

            // Add document
            AddStartPageDocument();
            //AddConfigDocument();
            //AddRevisionLogDocument();

            tabbedView.Controller.Activate(m_startPage);
            tabbedView.EndUpdate();
        }

        private void InitModuleGallery(GalleryItemGroup groupDropDown)
        {
            string[] moduleNames = {"Scene Editor", "Terrain Editor", "Character Editor", "Fx Editor", "Material Editor", "Cut Scene", "Path Finding", "Scene Walker"};
            int[] moudleImageIdx = { 14, 15, 8, 11, 12, 10, 13, 16 };

            for (int i = 0; i < moudleImageIdx.Length; i++)
            {
                GalleryItem item = new GalleryItem();
                item.Caption = moduleNames[i];
                //item.Description = moduleNames[i];
                item.Image = ribbonLargeImageCollection.Images[moudleImageIdx[i]];
                item.Hint = moduleNames[i];
                item.HoverImage = item.Image;
                groupDropDown.Items.Add(item);
            }
        }

        private void InitToolsGallery(GalleryItemGroup groupDropDown)
        {
            string[] toolNames = { "Resource Browser", "Resource Packer" };
            int[] toolImageIdx = { 9, 17 };

            for (int i = 0; i < toolImageIdx.Length; i++)
            {
                GalleryItem item = new GalleryItem();
                item.Caption = toolNames[i];
                //item.Description = moduleNames[i];
                item.Image = ribbonLargeImageCollection.Images[toolImageIdx[i]];
                item.Hint = toolNames[i];
                item.HoverImage = item.Image;
                groupDropDown.Items.Add(item);
            }
        }

        private void AddStartPageDocument()
        {
            m_startPage = tabbedView.Controller.AddDocument(new StartPage());
            m_startPage.Form.Text = "Start";
            m_startPage.Caption = "Start";
            m_startPage.Image = ribbonImageCollection.Images[21];

        }
        private void AddConfigDocument()
        {
            m_config = tabbedView.Controller.AddDocument(new Config());
            m_config.Form.Text = "Config";
            m_config.Caption = "Config";
            m_config.Image = ribbonImageCollection.Images[0];
        }
        private void AddRevisionLogDocument()
        {
            m_revisionLog = tabbedView.Controller.AddDocument(new RevisionLog());
            m_revisionLog.Form.Text = "Revision Log";
            m_revisionLog.Caption = "Revision Log";
            m_revisionLog.Image = ribbonImageCollection.Images[7];
        }

        private void Start_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tabbedView.Documents.Contains(m_startPage))
            {
                tabbedView.Controller.Activate(m_startPage);
            }
            else
            {
                AddStartPageDocument();
            }
        }
        private void Config_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tabbedView.Documents.Contains(m_config))
            {
                tabbedView.Controller.Activate(m_config);
            }
            else
            {
                AddConfigDocument();
            }
        }

        private void RevisionLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tabbedView.Documents.Contains(m_revisionLog))
            {
                tabbedView.Controller.Activate(m_revisionLog);
            }
            else
            {
                AddRevisionLogDocument();
            }
        }

        private void Module_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            if (m_sceneEditor == null || m_sceneEditor.IsDisposed)
            {
                m_sceneEditor = new SceneEditor();
                m_sceneEditor.DockToMainForm(dockManager);
                m_sceneEditor.Text = "Scene Editor";
                m_sceneEditor.MdiParent = this;
                m_sceneEditor.Show();
            }
            else
            {
                BaseDocument doc = documentManager.GetDocument(m_sceneEditor);
                tabbedView.Controller.Activate(doc);    
            }
        }

        private void MainRibbon_Merge(object sender, RibbonMergeEventArgs e)
        {
            RibbonControl main = sender as RibbonControl;
            if (e.MergedChild.Pages.Count > 0)
                main.SelectedPage = e.MergedChild.Pages[0];
        }

    }
}