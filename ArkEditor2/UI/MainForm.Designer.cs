namespace ArkEditor2.UI
{
    partial class MainForm
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ArkEditor2.UI.StartupSplashScreen), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.mainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.iConfig = new DevExpress.XtraBars.BarButtonItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.iHelp = new DevExpress.XtraBars.BarButtonItem();
            this.iRevisionLog = new DevExpress.XtraBars.BarButtonItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.iScene = new DevExpress.XtraBars.BarButtonItem();
            this.iTerrain = new DevExpress.XtraBars.BarButtonItem();
            this.iCharacter = new DevExpress.XtraBars.BarButtonItem();
            this.iFx = new DevExpress.XtraBars.BarButtonItem();
            this.iMaterial = new DevExpress.XtraBars.BarButtonItem();
            this.iCutScene = new DevExpress.XtraBars.BarButtonItem();
            this.iSceneWalker = new DevExpress.XtraBars.BarButtonItem();
            this.iPathFinding = new DevExpress.XtraBars.BarButtonItem();
            this.iResourcePacker = new DevExpress.XtraBars.BarButtonItem();
            this.iResourceBrowser = new DevExpress.XtraBars.BarButtonItem();
            this.iOutput = new DevExpress.XtraBars.BarButtonItem();
            this.iStartPage = new DevExpress.XtraBars.BarButtonItem();
            this.iMudoles = new DevExpress.XtraBars.BarButtonItem();
            this.moduleGallery = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.iTools = new DevExpress.XtraBars.BarButtonItem();
            this.toolGallery = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.sInfo = new DevExpress.XtraBars.BarStaticItem();
            this.progressItem = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.ribbonLargeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.homeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.navigationPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.appearancePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.preferencesPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.informationPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.exitPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pmSkins = new DevExpress.XtraBars.PopupMenu(this.components);
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpOutput = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleGallery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolGallery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonLargeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmSkins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dpOutput.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbon
            // 
            this.mainRibbon.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Appearance", new System.Guid("f2f3b10a-ef81-4079-825d-3125b051f5d4")),
            new DevExpress.XtraBars.BarManagerCategory("Preferences", new System.Guid("9f28ed7c-3c97-4795-8256-e4623b4cd171")),
            new DevExpress.XtraBars.BarManagerCategory("Navigation", new System.Guid("b68d787f-6ce1-4a76-bd90-7264e2342bf5")),
            new DevExpress.XtraBars.BarManagerCategory("Information", new System.Guid("9fb4434d-104d-4192-9442-a6f88afad3f0"))});
            this.mainRibbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Blue;
            this.mainRibbon.ExpandCollapseItem.Id = 0;
            this.mainRibbon.ExpandCollapseItem.Name = "";
            this.mainRibbon.Images = this.ribbonImageCollection;
            this.mainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbon.ExpandCollapseItem,
            this.rgbiSkins,
            this.iConfig,
            this.iAbout,
            this.iHelp,
            this.iRevisionLog,
            this.iExit,
            this.iScene,
            this.iTerrain,
            this.iCharacter,
            this.iFx,
            this.iMaterial,
            this.iCutScene,
            this.iSceneWalker,
            this.iPathFinding,
            this.iResourcePacker,
            this.iResourceBrowser,
            this.iOutput,
            this.iStartPage,
            this.iMudoles,
            this.iTools,
            this.sInfo,
            this.progressItem});
            this.mainRibbon.LargeImages = this.ribbonLargeImageCollection;
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.MaxItemId = 39;
            this.mainRibbon.Name = "mainRibbon";
            this.mainRibbon.PageHeaderItemLinks.Add(this.iHelp);
            this.mainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeRibbonPage});
            this.mainRibbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemCheckEdit1,
            this.repositoryItemProgressBar1});
            this.mainRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.mainRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.Size = new System.Drawing.Size(1014, 147);
            this.mainRibbon.StatusBar = this.ribbonStatusBar;
            this.mainRibbon.Merge += new DevExpress.XtraBars.Ribbon.RibbonMergeEventHandler(this.MainRibbon_Merge);
            this.mainRibbon.UnMerge += new DevExpress.XtraBars.Ribbon.RibbonMergeEventHandler(this.MainRibbon_UnMerge);
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Config_16x16, "Config_16x16", typeof(global::ArkEditor2.Properties.Resources), 0);
            this.ribbonImageCollection.Images.SetKeyName(0, "Config_16x16");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Close_16x16, "Close_16x16", typeof(global::ArkEditor2.Properties.Resources), 1);
            this.ribbonImageCollection.Images.SetKeyName(1, "Close_16x16");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Help_16x16, "Help_16x16", typeof(global::ArkEditor2.Properties.Resources), 2);
            this.ribbonImageCollection.Images.SetKeyName(2, "Help_16x16");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.info_16x16, "info_16x16", typeof(global::ArkEditor2.Properties.Resources), 3);
            this.ribbonImageCollection.Images.SetKeyName(3, "info_16x16");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Module_16x16, "Module_16x16", typeof(global::ArkEditor2.Properties.Resources), 4);
            this.ribbonImageCollection.Images.SetKeyName(4, "Module_16x16");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Tool_16x16, "Tool_16x16", typeof(global::ArkEditor2.Properties.Resources), 5);
            this.ribbonImageCollection.Images.SetKeyName(5, "Tool_16x16");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.About_16x16, "About_16x16", typeof(global::ArkEditor2.Properties.Resources), 6);
            this.ribbonImageCollection.Images.SetKeyName(6, "About_16x16");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Log_16x16, "Log_16x16", typeof(global::ArkEditor2.Properties.Resources), 7);
            this.ribbonImageCollection.Images.SetKeyName(7, "Log_16x16");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Actor_16x16, "Actor_16x16", typeof(global::ArkEditor2.Properties.Resources), 8);
            this.ribbonImageCollection.Images.SetKeyName(8, "Actor_16x16");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Browser_32x32, "Browser_32x32", typeof(global::ArkEditor2.Properties.Resources), 9);
            this.ribbonImageCollection.Images.SetKeyName(9, "Browser_32x32");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.CutScene_32x32, "CutScene_32x32", typeof(global::ArkEditor2.Properties.Resources), 10);
            this.ribbonImageCollection.Images.SetKeyName(10, "CutScene_32x32");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Fx_32x32, "Fx_32x32", typeof(global::ArkEditor2.Properties.Resources), 11);
            this.ribbonImageCollection.Images.SetKeyName(11, "Fx_32x32");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Material_32x32, "Material_32x32", typeof(global::ArkEditor2.Properties.Resources), 12);
            this.ribbonImageCollection.Images.SetKeyName(12, "Material_32x32");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Path_32x32, "Path_32x32", typeof(global::ArkEditor2.Properties.Resources), 13);
            this.ribbonImageCollection.Images.SetKeyName(13, "Path_32x32");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Scene_16x16, "Scene_16x16", typeof(global::ArkEditor2.Properties.Resources), 14);
            this.ribbonImageCollection.Images.SetKeyName(14, "Scene_16x16");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Terrain_32x32, "Terrain_32x32", typeof(global::ArkEditor2.Properties.Resources), 15);
            this.ribbonImageCollection.Images.SetKeyName(15, "Terrain_32x32");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Walker_32x32, "Walker_32x32", typeof(global::ArkEditor2.Properties.Resources), 16);
            this.ribbonImageCollection.Images.SetKeyName(16, "Walker_32x32");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Zip_32x32, "Zip_32x32", typeof(global::ArkEditor2.Properties.Resources), 17);
            this.ribbonImageCollection.Images.SetKeyName(17, "Zip_32x32");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Filter_32x32, "Filter_32x32", typeof(global::ArkEditor2.Properties.Resources), 18);
            this.ribbonImageCollection.Images.SetKeyName(18, "Filter_32x32");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Monitor_16x16, "Monitor_16x16", typeof(global::ArkEditor2.Properties.Resources), 19);
            this.ribbonImageCollection.Images.SetKeyName(19, "Monitor_16x16");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Palette_16x16, "Palette_16x16", typeof(global::ArkEditor2.Properties.Resources), 20);
            this.ribbonImageCollection.Images.SetKeyName(20, "Palette_16x16");
            this.ribbonImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Wizard_16x16, "Wizard_16x16", typeof(global::ArkEditor2.Properties.Resources), 21);
            this.ribbonImageCollection.Images.SetKeyName(21, "Wizard_16x16");
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            this.rgbiSkins.CategoryGuid = new System.Guid("f2f3b10a-ef81-4079-825d-3125b051f5d4");
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Gallery.AllowHoverImages = true;
            this.rgbiSkins.Gallery.ColumnCount = 4;
            this.rgbiSkins.Gallery.FixedHoverImageSize = false;
            this.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.rgbiSkins.Gallery.RowCount = 4;
            this.rgbiSkins.Id = 3;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // iConfig
            // 
            this.iConfig.Caption = "&Config";
            this.iConfig.CategoryGuid = new System.Guid("9f28ed7c-3c97-4795-8256-e4623b4cd171");
            this.iConfig.Id = 6;
            this.iConfig.ImageIndex = 0;
            this.iConfig.LargeImageIndex = 0;
            this.iConfig.Name = "iConfig";
            this.iConfig.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Config_ItemClick);
            // 
            // iAbout
            // 
            this.iAbout.Caption = "&About";
            this.iAbout.CategoryGuid = new System.Guid("9fb4434d-104d-4192-9442-a6f88afad3f0");
            this.iAbout.Id = 9;
            this.iAbout.ImageIndex = 6;
            this.iAbout.LargeImageIndex = 6;
            this.iAbout.Name = "iAbout";
            // 
            // iHelp
            // 
            this.iHelp.Caption = "&Help";
            this.iHelp.CategoryGuid = new System.Guid("9fb4434d-104d-4192-9442-a6f88afad3f0");
            this.iHelp.Id = 11;
            this.iHelp.ImageIndex = 2;
            this.iHelp.LargeImageIndex = 2;
            this.iHelp.Name = "iHelp";
            // 
            // iRevisionLog
            // 
            this.iRevisionLog.Caption = "&Revision Log";
            this.iRevisionLog.CategoryGuid = new System.Guid("9fb4434d-104d-4192-9442-a6f88afad3f0");
            this.iRevisionLog.Id = 12;
            this.iRevisionLog.ImageIndex = 7;
            this.iRevisionLog.LargeImageIndex = 7;
            this.iRevisionLog.Name = "iRevisionLog";
            this.iRevisionLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RevisionLog_ItemClick);
            // 
            // iExit
            // 
            this.iExit.Caption = "E&xit";
            this.iExit.Id = 13;
            this.iExit.ImageIndex = 1;
            this.iExit.LargeImageIndex = 1;
            this.iExit.Name = "iExit";
            // 
            // iScene
            // 
            this.iScene.Caption = "Scene Editor";
            this.iScene.Id = 16;
            this.iScene.ImageIndex = 14;
            this.iScene.LargeImageIndex = 14;
            this.iScene.Name = "iScene";
            // 
            // iTerrain
            // 
            this.iTerrain.Caption = "Terrain Editor";
            this.iTerrain.Id = 17;
            this.iTerrain.ImageIndex = 15;
            this.iTerrain.LargeImageIndex = 15;
            this.iTerrain.Name = "iTerrain";
            // 
            // iCharacter
            // 
            this.iCharacter.Caption = "Character Editor";
            this.iCharacter.Id = 18;
            this.iCharacter.ImageIndex = 8;
            this.iCharacter.LargeImageIndex = 8;
            this.iCharacter.Name = "iCharacter";
            // 
            // iFx
            // 
            this.iFx.Caption = "Fx Editor";
            this.iFx.Id = 19;
            this.iFx.ImageIndex = 11;
            this.iFx.LargeImageIndex = 11;
            this.iFx.Name = "iFx";
            // 
            // iMaterial
            // 
            this.iMaterial.Caption = "Material Editor";
            this.iMaterial.Id = 20;
            this.iMaterial.ImageIndex = 12;
            this.iMaterial.LargeImageIndex = 12;
            this.iMaterial.Name = "iMaterial";
            // 
            // iCutScene
            // 
            this.iCutScene.Caption = "Cut Scene";
            this.iCutScene.Id = 21;
            this.iCutScene.ImageIndex = 10;
            this.iCutScene.LargeImageIndex = 10;
            this.iCutScene.Name = "iCutScene";
            // 
            // iSceneWalker
            // 
            this.iSceneWalker.Caption = "Scene Walker";
            this.iSceneWalker.Id = 22;
            this.iSceneWalker.ImageIndex = 16;
            this.iSceneWalker.LargeImageIndex = 16;
            this.iSceneWalker.Name = "iSceneWalker";
            // 
            // iPathFinding
            // 
            this.iPathFinding.Caption = "Path Finding";
            this.iPathFinding.Id = 23;
            this.iPathFinding.ImageIndex = 13;
            this.iPathFinding.LargeImageIndex = 13;
            this.iPathFinding.Name = "iPathFinding";
            // 
            // iResourcePacker
            // 
            this.iResourcePacker.Caption = "Resource Packer";
            this.iResourcePacker.Id = 25;
            this.iResourcePacker.ImageIndex = 17;
            this.iResourcePacker.LargeImageIndex = 17;
            this.iResourcePacker.Name = "iResourcePacker";
            // 
            // iResourceBrowser
            // 
            this.iResourceBrowser.Caption = "Resource Browser";
            this.iResourceBrowser.Id = 26;
            this.iResourceBrowser.ImageIndex = 9;
            this.iResourceBrowser.LargeImageIndex = 9;
            this.iResourceBrowser.Name = "iResourceBrowser";
            // 
            // iOutput
            // 
            this.iOutput.Caption = "&Output";
            this.iOutput.Id = 27;
            this.iOutput.ImageIndex = 19;
            this.iOutput.LargeImageIndex = 19;
            this.iOutput.Name = "iOutput";
            // 
            // iStartPage
            // 
            this.iStartPage.Caption = "&Start";
            this.iStartPage.Id = 31;
            this.iStartPage.ImageIndex = 21;
            this.iStartPage.LargeImageIndex = 21;
            this.iStartPage.Name = "iStartPage";
            this.iStartPage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Start_ItemClick);
            // 
            // iMudoles
            // 
            this.iMudoles.ActAsDropDown = true;
            this.iMudoles.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.iMudoles.Caption = "Mudoles";
            this.iMudoles.DropDownControl = this.moduleGallery;
            this.iMudoles.Hint = "Mudoles";
            this.iMudoles.Id = 35;
            this.iMudoles.ImageIndex = 4;
            this.iMudoles.LargeImageIndex = 4;
            this.iMudoles.Name = "iMudoles";
            // 
            // moduleGallery
            // 
            // 
            // moduleGallery
            // 
            this.moduleGallery.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            this.moduleGallery.Gallery.ColumnCount = 4;
            galleryItemGroup1.Caption = "Modules";
            this.moduleGallery.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.moduleGallery.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.moduleGallery.Gallery.ShowItemText = true;
            this.moduleGallery.Name = "moduleGallery";
            this.moduleGallery.Ribbon = this.mainRibbon;
            this.moduleGallery.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.Module_GalleryItemClick);
            // 
            // iTools
            // 
            this.iTools.ActAsDropDown = true;
            this.iTools.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.iTools.Caption = "Tools";
            this.iTools.DropDownControl = this.toolGallery;
            this.iTools.Id = 36;
            this.iTools.ImageIndex = 5;
            this.iTools.LargeImageIndex = 5;
            this.iTools.Name = "iTools";
            // 
            // toolGallery
            // 
            // 
            // toolGallery
            // 
            this.toolGallery.Gallery.AutoSize = DevExpress.XtraBars.Ribbon.GallerySizeMode.Both;
            galleryItemGroup2.Caption = "Tools";
            this.toolGallery.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
            this.toolGallery.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.toolGallery.Gallery.ShowItemText = true;
            this.toolGallery.Name = "toolGallery";
            this.toolGallery.Ribbon = this.mainRibbon;
            // 
            // sInfo
            // 
            this.sInfo.Caption = "Ready";
            this.sInfo.Id = 37;
            this.sInfo.Name = "sInfo";
            this.sInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // progressItem
            // 
            this.progressItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.progressItem.Caption = "Loading";
            this.progressItem.Edit = this.repositoryItemProgressBar1;
            this.progressItem.EditValue = 50;
            this.progressItem.Id = 38;
            this.progressItem.Name = "progressItem";
            this.progressItem.Width = 200;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // ribbonLargeImageCollection
            // 
            this.ribbonLargeImageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonLargeImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonLargeImageCollection.ImageStream")));
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Config_32x32, "Config_32x32", typeof(global::ArkEditor2.Properties.Resources), 0);
            this.ribbonLargeImageCollection.Images.SetKeyName(0, "Config_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Close_32x32, "Close_32x32", typeof(global::ArkEditor2.Properties.Resources), 1);
            this.ribbonLargeImageCollection.Images.SetKeyName(1, "Close_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Help_32x32, "Help_32x32", typeof(global::ArkEditor2.Properties.Resources), 2);
            this.ribbonLargeImageCollection.Images.SetKeyName(2, "Help_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Info_32x32, "Info_32x32", typeof(global::ArkEditor2.Properties.Resources), 3);
            this.ribbonLargeImageCollection.Images.SetKeyName(3, "Info_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Module_32x32, "Module_32x32", typeof(global::ArkEditor2.Properties.Resources), 4);
            this.ribbonLargeImageCollection.Images.SetKeyName(4, "Module_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Tool_32x32, "Tool_32x32", typeof(global::ArkEditor2.Properties.Resources), 5);
            this.ribbonLargeImageCollection.Images.SetKeyName(5, "Tool_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.About_32x32, "About_32x32", typeof(global::ArkEditor2.Properties.Resources), 6);
            this.ribbonLargeImageCollection.Images.SetKeyName(6, "About_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Log_32x32, "Log_32x32", typeof(global::ArkEditor2.Properties.Resources), 7);
            this.ribbonLargeImageCollection.Images.SetKeyName(7, "Log_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Actor_32x32, "Actor_32x32", typeof(global::ArkEditor2.Properties.Resources), 8);
            this.ribbonLargeImageCollection.Images.SetKeyName(8, "Actor_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Browser_32x32, "Browser_32x32", typeof(global::ArkEditor2.Properties.Resources), 9);
            this.ribbonLargeImageCollection.Images.SetKeyName(9, "Browser_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.CutScene_32x32, "CutScene_32x32", typeof(global::ArkEditor2.Properties.Resources), 10);
            this.ribbonLargeImageCollection.Images.SetKeyName(10, "CutScene_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Fx_32x32, "Fx_32x32", typeof(global::ArkEditor2.Properties.Resources), 11);
            this.ribbonLargeImageCollection.Images.SetKeyName(11, "Fx_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Material_32x32, "Material_32x32", typeof(global::ArkEditor2.Properties.Resources), 12);
            this.ribbonLargeImageCollection.Images.SetKeyName(12, "Material_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Path_32x32, "Path_32x32", typeof(global::ArkEditor2.Properties.Resources), 13);
            this.ribbonLargeImageCollection.Images.SetKeyName(13, "Path_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Scene_32x32, "Scene_32x32", typeof(global::ArkEditor2.Properties.Resources), 14);
            this.ribbonLargeImageCollection.Images.SetKeyName(14, "Scene_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Terrain_32x32, "Terrain_32x32", typeof(global::ArkEditor2.Properties.Resources), 15);
            this.ribbonLargeImageCollection.Images.SetKeyName(15, "Terrain_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Walker_32x32, "Walker_32x32", typeof(global::ArkEditor2.Properties.Resources), 16);
            this.ribbonLargeImageCollection.Images.SetKeyName(16, "Walker_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Zip_32x32, "Zip_32x32", typeof(global::ArkEditor2.Properties.Resources), 17);
            this.ribbonLargeImageCollection.Images.SetKeyName(17, "Zip_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Filter_32x32, "Filter_32x32", typeof(global::ArkEditor2.Properties.Resources), 18);
            this.ribbonLargeImageCollection.Images.SetKeyName(18, "Filter_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Monitor_32x32, "Monitor_32x32", typeof(global::ArkEditor2.Properties.Resources), 19);
            this.ribbonLargeImageCollection.Images.SetKeyName(19, "Monitor_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Palette_32x32, "Palette_32x32", typeof(global::ArkEditor2.Properties.Resources), 20);
            this.ribbonLargeImageCollection.Images.SetKeyName(20, "Palette_32x32");
            this.ribbonLargeImageCollection.InsertImage(global::ArkEditor2.Properties.Resources.Wizard_32x32, "Wizard_32x32", typeof(global::ArkEditor2.Properties.Resources), 21);
            this.ribbonLargeImageCollection.Images.SetKeyName(21, "Wizard_32x32");
            // 
            // homeRibbonPage
            // 
            this.homeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.navigationPageGroup,
            this.appearancePageGroup,
            this.preferencesPageGroup,
            this.informationPageGroup,
            this.exitPageGroup});
            this.homeRibbonPage.Name = "homeRibbonPage";
            this.homeRibbonPage.Text = "Home";
            // 
            // navigationPageGroup
            // 
            this.navigationPageGroup.ItemLinks.Add(this.iMudoles);
            this.navigationPageGroup.ItemLinks.Add(this.iTools);
            this.navigationPageGroup.Name = "navigationPageGroup";
            this.navigationPageGroup.ShowCaptionButton = false;
            this.navigationPageGroup.Text = "Navigation";
            // 
            // appearancePageGroup
            // 
            this.appearancePageGroup.ItemLinks.Add(this.rgbiSkins);
            this.appearancePageGroup.Name = "appearancePageGroup";
            this.appearancePageGroup.Text = "Appearance";
            this.appearancePageGroup.CaptionButtonClick += new DevExpress.XtraBars.Ribbon.RibbonPageGroupEventHandler(this.AppearancePageGroup_CaptionButtonClick);
            // 
            // preferencesPageGroup
            // 
            this.preferencesPageGroup.ItemLinks.Add(this.iConfig);
            this.preferencesPageGroup.ItemLinks.Add(this.iStartPage);
            this.preferencesPageGroup.Name = "preferencesPageGroup";
            this.preferencesPageGroup.ShowCaptionButton = false;
            this.preferencesPageGroup.Text = "Options";
            // 
            // informationPageGroup
            // 
            this.informationPageGroup.ItemLinks.Add(this.iRevisionLog);
            this.informationPageGroup.ItemLinks.Add(this.iAbout);
            this.informationPageGroup.Name = "informationPageGroup";
            this.informationPageGroup.ShowCaptionButton = false;
            this.informationPageGroup.Text = "Info";
            // 
            // exitPageGroup
            // 
            this.exitPageGroup.ItemLinks.Add(this.iExit);
            this.exitPageGroup.Name = "exitPageGroup";
            this.exitPageGroup.ShowCaptionButton = false;
            this.exitPageGroup.Text = "Exit";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "All",
            "Scene Editor",
            "Terrain Editor",
            "Character Editor",
            "Fx Editor",
            "Material Editor",
            "Cut Scene",
            "Path Finding",
            "Scene Walker"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            "All",
            "Message",
            "Warning",
            "Error"});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            this.repositoryItemComboBox2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.sInfo);
            this.ribbonStatusBar.ItemLinks.Add(this.progressItem, true);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 648);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.mainRibbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1014, 31);
            // 
            // pmSkins
            // 
            this.pmSkins.Name = "pmSkins";
            this.pmSkins.Ribbon = this.mainRibbon;
            // 
            // documentManager
            // 
            this.documentManager.MdiParent = this;
            this.documentManager.MenuManager = this.mainRibbon;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // tabbedView
            // 
            this.tabbedView.DocumentProperties.UseFormIconAsDocumentImage = true;
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.Images = this.ribbonImageCollection;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpOutput});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dpOutput
            // 
            this.dpOutput.Controls.Add(this.dockPanel1_Container);
            this.dpOutput.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dpOutput.ID = new System.Guid("90bd5916-c690-4ade-8164-c415ad4f64a1");
            this.dpOutput.ImageIndex = 19;
            this.dpOutput.Location = new System.Drawing.Point(0, 448);
            this.dpOutput.Name = "dpOutput";
            this.dpOutput.OriginalSize = new System.Drawing.Size(200, 200);
            this.dpOutput.Size = new System.Drawing.Size(1014, 200);
            this.dpOutput.Text = "Output";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.memoEdit1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1006, 173);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.Location = new System.Drawing.Point(0, 0);
            this.memoEdit1.MenuManager = this.mainRibbon;
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(1006, 173);
            this.memoEdit1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 679);
            this.Controls.Add(this.dpOutput);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.mainRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.mainRibbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Ark Editor 2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleGallery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolGallery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonLargeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmSkins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dpOutput.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage homeRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup appearancePageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.PopupMenu pmSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup preferencesPageGroup;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonLargeImageCollection;
        private DevExpress.XtraBars.BarButtonItem iConfig;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup navigationPageGroup;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraBars.BarButtonItem iHelp;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup informationPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup exitPageGroup;
        private DevExpress.XtraBars.BarButtonItem iRevisionLog;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.BarButtonItem iScene;
        private DevExpress.XtraBars.BarButtonItem iTerrain;
        private DevExpress.XtraBars.BarButtonItem iCharacter;
        private DevExpress.XtraBars.BarButtonItem iFx;
        private DevExpress.XtraBars.BarButtonItem iMaterial;
        private DevExpress.XtraBars.BarButtonItem iCutScene;
        private DevExpress.XtraBars.BarButtonItem iPathFinding;
        private DevExpress.XtraBars.BarButtonItem iSceneWalker;
        private DevExpress.XtraBars.BarButtonItem iResourceBrowser;
        private DevExpress.XtraBars.BarButtonItem iResourcePacker;
        private DevExpress.XtraBars.BarButtonItem iOutput;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraBars.BarButtonItem iStartPage;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown moduleGallery;
        private DevExpress.XtraBars.BarButtonItem iMudoles;
        private DevExpress.XtraBars.BarButtonItem iTools;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown toolGallery;
        private DevExpress.XtraBars.Docking.DockPanel dpOutput;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.BarStaticItem sInfo;
        private DevExpress.XtraBars.BarEditItem progressItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
    }
}