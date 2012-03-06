namespace ArkEditor2.UI
{
    partial class SceneEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SceneEditor));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImages = new DevExpress.Utils.ImageCollection(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.itemTrack = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.sInfo = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.largeImages = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Images = this.smallImages;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.itemTrack,
            this.sInfo,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barButtonItem14,
            this.barButtonItem15,
            this.barButtonItem16});
            this.ribbon.LargeImages = this.largeImages;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 22;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTrackBar1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(749, 147);
            // 
            // smallImages
            // 
            this.smallImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImages.ImageStream")));
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.AddToLibrary_16x16, "AddToLibrary_16x16", typeof(global::ArkEditor2.Properties.Resources), 0);
            this.smallImages.Images.SetKeyName(0, "AddToLibrary_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Clone_16x16, "Clone_16x16", typeof(global::ArkEditor2.Properties.Resources), 1);
            this.smallImages.Images.SetKeyName(1, "Clone_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Copy_16x16, "Copy_16x16", typeof(global::ArkEditor2.Properties.Resources), 2);
            this.smallImages.Images.SetKeyName(2, "Copy_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Cut_16x16, "Cut_16x16", typeof(global::ArkEditor2.Properties.Resources), 3);
            this.smallImages.Images.SetKeyName(3, "Cut_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Edit_16x16, "Edit_16x16", typeof(global::ArkEditor2.Properties.Resources), 4);
            this.smallImages.Images.SetKeyName(4, "Edit_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Export_16x16, "Export_16x16", typeof(global::ArkEditor2.Properties.Resources), 5);
            this.smallImages.Images.SetKeyName(5, "Export_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Filter_16x16, "Filter_16x16", typeof(global::ArkEditor2.Properties.Resources), 6);
            this.smallImages.Images.SetKeyName(6, "Filter_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.find_16x16, "find_16x16", typeof(global::ArkEditor2.Properties.Resources), 7);
            this.smallImages.Images.SetKeyName(7, "find_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Folder_16x16, "Folder_16x16", typeof(global::ArkEditor2.Properties.Resources), 8);
            this.smallImages.Images.SetKeyName(8, "Folder_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.new_16x16, "new_16x16", typeof(global::ArkEditor2.Properties.Resources), 9);
            this.smallImages.Images.SetKeyName(9, "new_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.paste_16x16, "paste_16x16", typeof(global::ArkEditor2.Properties.Resources), 10);
            this.smallImages.Images.SetKeyName(10, "paste_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Redo_16x16, "Redo_16x16", typeof(global::ArkEditor2.Properties.Resources), 11);
            this.smallImages.Images.SetKeyName(11, "Redo_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Refresh_16x16, "Refresh_16x16", typeof(global::ArkEditor2.Properties.Resources), 12);
            this.smallImages.Images.SetKeyName(12, "Refresh_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Remove_16x16, "Remove_16x16", typeof(global::ArkEditor2.Properties.Resources), 13);
            this.smallImages.Images.SetKeyName(13, "Remove_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Save_16x16, "Save_16x16", typeof(global::ArkEditor2.Properties.Resources), 14);
            this.smallImages.Images.SetKeyName(14, "Save_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.SaveAs_16x16, "SaveAs_16x16", typeof(global::ArkEditor2.Properties.Resources), 15);
            this.smallImages.Images.SetKeyName(15, "SaveAs_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Undo_16x16, "Undo_16x16", typeof(global::ArkEditor2.Properties.Resources), 16);
            this.smallImages.Images.SetKeyName(16, "Undo_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Views_16x16, "Views_16x16", typeof(global::ArkEditor2.Properties.Resources), 17);
            this.smallImages.Images.SetKeyName(17, "Views_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.CloseFolder_16x16, "CloseFolder_16x16", typeof(global::ArkEditor2.Properties.Resources), 18);
            this.smallImages.Images.SetKeyName(18, "CloseFolder_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.SaveAll_16x16, "SaveAll_16x16", typeof(global::ArkEditor2.Properties.Resources), 19);
            this.smallImages.Images.SetKeyName(19, "SaveAll_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Export_16x16, "Export_16x16", typeof(global::ArkEditor2.Properties.Resources), 20);
            this.smallImages.Images.SetKeyName(20, "Export_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Export2_16x16, "Export2_16x16", typeof(global::ArkEditor2.Properties.Resources), 21);
            this.smallImages.Images.SetKeyName(21, "Export2_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Open_16x16, "Open_16x16", typeof(global::ArkEditor2.Properties.Resources), 22);
            this.smallImages.Images.SetKeyName(22, "Open_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Camera_16x16, "Camera_16x16", typeof(global::ArkEditor2.Properties.Resources), 23);
            this.smallImages.Images.SetKeyName(23, "Camera_16x16");
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Close Scene Editor";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Close_ItemClick);
            // 
            // itemTrack
            // 
            this.itemTrack.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.itemTrack.Caption = "Track";
            this.itemTrack.Edit = this.repositoryItemTrackBar1;
            this.itemTrack.Id = 3;
            this.itemTrack.Name = "itemTrack";
            this.itemTrack.Width = 150;
            // 
            // repositoryItemTrackBar1
            // 
            this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
            // 
            // sInfo
            // 
            this.sInfo.Caption = "Scene Editor";
            this.sInfo.Id = 4;
            this.sInfo.Name = "sInfo";
            this.sInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "&Open";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.ImageIndex = 22;
            this.barButtonItem2.LargeImageIndex = 22;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "New";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.ImageIndex = 9;
            this.barButtonItem3.LargeImageIndex = 9;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Close";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.ImageIndex = 18;
            this.barButtonItem4.LargeImageIndex = 18;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Save";
            this.barButtonItem5.Id = 8;
            this.barButtonItem5.ImageIndex = 14;
            this.barButtonItem5.LargeImageIndex = 14;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Save as";
            this.barButtonItem6.Id = 9;
            this.barButtonItem6.ImageIndex = 19;
            this.barButtonItem6.LargeImageIndex = 19;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Save asset";
            this.barButtonItem7.Id = 10;
            this.barButtonItem7.ImageIndex = 15;
            this.barButtonItem7.LargeImageIndex = 15;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Export";
            this.barButtonItem8.Id = 11;
            this.barButtonItem8.ImageIndex = 21;
            this.barButtonItem8.LargeImageIndex = 21;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Clone";
            this.barButtonItem9.Id = 12;
            this.barButtonItem9.ImageIndex = 1;
            this.barButtonItem9.LargeImageIndex = 1;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Paste";
            this.barButtonItem10.Id = 13;
            this.barButtonItem10.ImageIndex = 10;
            this.barButtonItem10.LargeImageIndex = 10;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Cut";
            this.barButtonItem11.Id = 14;
            this.barButtonItem11.ImageIndex = 3;
            this.barButtonItem11.LargeImageIndex = 3;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Copy";
            this.barButtonItem12.Id = 15;
            this.barButtonItem12.ImageIndex = 2;
            this.barButtonItem12.LargeImageIndex = 2;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Delete";
            this.barButtonItem13.Id = 16;
            this.barButtonItem13.ImageIndex = 13;
            this.barButtonItem13.LargeImageIndex = 13;
            this.barButtonItem13.Name = "barButtonItem13";
            this.barButtonItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.ActAsDropDown = true;
            this.barButtonItem14.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem14.Caption = "Find";
            this.barButtonItem14.Id = 19;
            this.barButtonItem14.ImageIndex = 7;
            this.barButtonItem14.LargeImageIndex = 7;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.ActAsDropDown = true;
            this.barButtonItem15.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem15.Caption = "Filter";
            this.barButtonItem15.Id = 20;
            this.barButtonItem15.ImageIndex = 6;
            this.barButtonItem15.LargeImageIndex = 6;
            this.barButtonItem15.Name = "barButtonItem15";
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.ActAsDropDown = true;
            this.barButtonItem16.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem16.Caption = "Camera";
            this.barButtonItem16.Id = 21;
            this.barButtonItem16.ImageIndex = 23;
            this.barButtonItem16.LargeImageIndex = 23;
            this.barButtonItem16.Name = "barButtonItem16";
            // 
            // largeImages
            // 
            this.largeImages.ImageSize = new System.Drawing.Size(32, 32);
            this.largeImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("largeImages.ImageStream")));
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.AddToLibrary_32x32, "AddToLibrary_32x32", typeof(global::ArkEditor2.Properties.Resources), 0);
            this.largeImages.Images.SetKeyName(0, "AddToLibrary_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Clone_32x32, "Clone_32x32", typeof(global::ArkEditor2.Properties.Resources), 1);
            this.largeImages.Images.SetKeyName(1, "Clone_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Copy_32x32, "Copy_32x32", typeof(global::ArkEditor2.Properties.Resources), 2);
            this.largeImages.Images.SetKeyName(2, "Copy_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Cut_32x32, "Cut_32x32", typeof(global::ArkEditor2.Properties.Resources), 3);
            this.largeImages.Images.SetKeyName(3, "Cut_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Edit_32x32, "Edit_32x32", typeof(global::ArkEditor2.Properties.Resources), 4);
            this.largeImages.Images.SetKeyName(4, "Edit_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Export_32x32, "Export_32x32", typeof(global::ArkEditor2.Properties.Resources), 5);
            this.largeImages.Images.SetKeyName(5, "Export_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Filter_32x32, "Filter_32x32", typeof(global::ArkEditor2.Properties.Resources), 6);
            this.largeImages.Images.SetKeyName(6, "Filter_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Find_32x32, "Find_32x32", typeof(global::ArkEditor2.Properties.Resources), 7);
            this.largeImages.Images.SetKeyName(7, "Find_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Folder_32x32, "Folder_32x32", typeof(global::ArkEditor2.Properties.Resources), 8);
            this.largeImages.Images.SetKeyName(8, "Folder_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.new_32x32, "new_32x32", typeof(global::ArkEditor2.Properties.Resources), 9);
            this.largeImages.Images.SetKeyName(9, "new_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.paste_32x32, "paste_32x32", typeof(global::ArkEditor2.Properties.Resources), 10);
            this.largeImages.Images.SetKeyName(10, "paste_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Redo_32x32, "Redo_32x32", typeof(global::ArkEditor2.Properties.Resources), 11);
            this.largeImages.Images.SetKeyName(11, "Redo_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Refresh_32x32, "Refresh_32x32", typeof(global::ArkEditor2.Properties.Resources), 12);
            this.largeImages.Images.SetKeyName(12, "Refresh_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Remove_32x32, "Remove_32x32", typeof(global::ArkEditor2.Properties.Resources), 13);
            this.largeImages.Images.SetKeyName(13, "Remove_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Save_32x32, "Save_32x32", typeof(global::ArkEditor2.Properties.Resources), 14);
            this.largeImages.Images.SetKeyName(14, "Save_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.SaveAs_32x32, "SaveAs_32x32", typeof(global::ArkEditor2.Properties.Resources), 15);
            this.largeImages.Images.SetKeyName(15, "SaveAs_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Undo_32x32, "Undo_32x32", typeof(global::ArkEditor2.Properties.Resources), 16);
            this.largeImages.Images.SetKeyName(16, "Undo_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Views_32x32, "Views_32x32", typeof(global::ArkEditor2.Properties.Resources), 17);
            this.largeImages.Images.SetKeyName(17, "Views_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.CloseFolder_32x32, "CloseFolder_32x32", typeof(global::ArkEditor2.Properties.Resources), 18);
            this.largeImages.Images.SetKeyName(18, "CloseFolder_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.SaveAll_32x32, "SaveAll_32x32", typeof(global::ArkEditor2.Properties.Resources), 19);
            this.largeImages.Images.SetKeyName(19, "SaveAll_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Export_16x16, "Export_16x16", typeof(global::ArkEditor2.Properties.Resources), 20);
            this.largeImages.Images.SetKeyName(20, "Export_16x16");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Export2_32x32, "Export2_32x32", typeof(global::ArkEditor2.Properties.Resources), 21);
            this.largeImages.Images.SetKeyName(21, "Export2_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Open_32x32, "Open_32x32", typeof(global::ArkEditor2.Properties.Resources), 22);
            this.largeImages.Images.SetKeyName(22, "Open_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Camera_32x32, "Camera_32x32", typeof(global::ArkEditor2.Properties.Resources), 23);
            this.largeImages.Images.SetKeyName(23, "Camera_32x32");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Scene Editor";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem5, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "File";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem13);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Edit";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem14);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem15);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Find";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem16);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Camera";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Exit";
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // SceneEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 437);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SceneEditor";
            this.Ribbon = this.ribbon;
            this.Text = "Scene Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SceneExplorer_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.BarEditItem itemTrack;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
        private DevExpress.XtraBars.BarStaticItem sInfo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.Utils.ImageCollection smallImages;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.Utils.ImageCollection largeImages;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
    }
}