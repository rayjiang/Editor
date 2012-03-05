using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Docking2010.Views;

namespace ArkEditor2.UI
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
            // Init Gallery
            InitModuleGallery(moduleGallery.Gallery.Groups[0]);
            InitToolsGallery(toolGallery.Gallery.Groups[0]);

            // Init Tabbed View
            tabbedView.BeginUpdate();

            // Add start page
            BaseDocument startPage = tabbedView.Controller.AddDocument(new StartPage());
            startPage.Form.Text = "Start";
            startPage.Caption = "Start";
            startPage.Image = ribbonImageCollection.Images[21];

            BaseDocument configPage = tabbedView.Controller.AddDocument(new Config());
            configPage.Form.Text = "Config";
            configPage.Caption = "Config";
            configPage.Image = ribbonImageCollection.Images[0];

            BaseDocument revisionPage = tabbedView.Controller.AddDocument(new RevisionLog());
            revisionPage.Form.Text = "Revision Log";
            revisionPage.Caption = "Revision Log";
            revisionPage.Image = ribbonImageCollection.Images[7];

            tabbedView.Controller.Activate(startPage);
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
    }
}