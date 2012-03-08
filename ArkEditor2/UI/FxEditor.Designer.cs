namespace ArkEditor2.UI
{
    partial class FxEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FxEditor));
            this.mainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImages = new DevExpress.Utils.ImageCollection(this.components);
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.largeImages = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.m_dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpSettings = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ucSetting = new ArkEditor2.UI.FxSettings();
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dpTimeLine = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ucTimeLine = new ArkEditor2.UI.FxTimeLine();
            this.dpChannel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ucChannel = new ArkEditor2.UI.FxChannel();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dockManager)).BeginInit();
            this.dpSettings.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.panelContainer1.SuspendLayout();
            this.dpTimeLine.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            this.dpChannel.SuspendLayout();
            this.dockPanel3_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainRibbon
            // 
            this.mainRibbon.ExpandCollapseItem.Id = 0;
            this.mainRibbon.ExpandCollapseItem.Name = "";
            this.mainRibbon.Images = this.smallImages;
            this.mainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbon.ExpandCollapseItem,
            this.barStaticItem1,
            this.iExit,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.mainRibbon.LargeImages = this.largeImages;
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.MaxItemId = 8;
            this.mainRibbon.Name = "mainRibbon";
            this.mainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.mainRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.mainRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbon.Size = new System.Drawing.Size(738, 147);
            this.mainRibbon.StatusBar = this.ribbonStatusBar;
            this.mainRibbon.TransparentEditors = true;
            // 
            // smallImages
            // 
            this.smallImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImages.ImageStream")));
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.new_16x16, "new_16x16", typeof(global::ArkEditor2.Properties.Resources), 0);
            this.smallImages.Images.SetKeyName(0, "new_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Open_16x16, "Open_16x16", typeof(global::ArkEditor2.Properties.Resources), 1);
            this.smallImages.Images.SetKeyName(1, "Open_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Save_16x16, "Save_16x16", typeof(global::ArkEditor2.Properties.Resources), 2);
            this.smallImages.Images.SetKeyName(2, "Save_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.SaveAll_16x16, "SaveAll_16x16", typeof(global::ArkEditor2.Properties.Resources), 3);
            this.smallImages.Images.SetKeyName(3, "SaveAll_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.CloseFolder_16x16, "CloseFolder_16x16", typeof(global::ArkEditor2.Properties.Resources), 4);
            this.smallImages.Images.SetKeyName(4, "CloseFolder_16x16");
            this.smallImages.InsertImage(global::ArkEditor2.Properties.Resources.Palette_16x16, "Palette_16x16", typeof(global::ArkEditor2.Properties.Resources), 5);
            this.smallImages.Images.SetKeyName(5, "Palette_16x16");
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Fx Editor";
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // iExit
            // 
            this.iExit.Caption = "Close Fx Edirtor";
            this.iExit.Glyph = global::ArkEditor2.Properties.Resources.Close_16x16;
            this.iExit.Id = 2;
            this.iExit.LargeGlyph = global::ArkEditor2.Properties.Resources.Close_32x32;
            this.iExit.Name = "iExit";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Close_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "New";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageIndex = 0;
            this.barButtonItem1.LargeImageIndex = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Open";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.ImageIndex = 1;
            this.barButtonItem2.LargeImageIndex = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Close";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.ImageIndex = 4;
            this.barButtonItem3.LargeImageIndex = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Save";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.ImageIndex = 2;
            this.barButtonItem4.LargeImageIndex = 2;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Save as";
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.ImageIndex = 3;
            this.barButtonItem5.LargeImageIndex = 3;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // largeImages
            // 
            this.largeImages.ImageSize = new System.Drawing.Size(32, 32);
            this.largeImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("largeImages.ImageStream")));
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.new_32x32, "new_32x32", typeof(global::ArkEditor2.Properties.Resources), 0);
            this.largeImages.Images.SetKeyName(0, "new_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Open_32x32, "Open_32x32", typeof(global::ArkEditor2.Properties.Resources), 1);
            this.largeImages.Images.SetKeyName(1, "Open_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.Save_32x32, "Save_32x32", typeof(global::ArkEditor2.Properties.Resources), 2);
            this.largeImages.Images.SetKeyName(2, "Save_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.SaveAll_32x32, "SaveAll_32x32", typeof(global::ArkEditor2.Properties.Resources), 3);
            this.largeImages.Images.SetKeyName(3, "SaveAll_32x32");
            this.largeImages.InsertImage(global::ArkEditor2.Properties.Resources.CloseFolder_32x32, "CloseFolder_32x32", typeof(global::ArkEditor2.Properties.Resources), 4);
            this.largeImages.Images.SetKeyName(4, "CloseFolder_32x32");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Fx Editor";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "File";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.iExit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Exit";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 515);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.mainRibbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(738, 31);
            // 
            // m_dockManager
            // 
            this.m_dockManager.Form = this;
            this.m_dockManager.Images = this.smallImages;
            this.m_dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpSettings,
            this.panelContainer1});
            this.m_dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dpSettings
            // 
            this.dpSettings.Controls.Add(this.dockPanel1_Container);
            this.dpSettings.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dpSettings.ID = new System.Guid("71114482-f229-4be3-842d-1f1af89c157e");
            this.dpSettings.ImageIndex = 5;
            this.dpSettings.Location = new System.Drawing.Point(562, 147);
            this.dpSettings.Name = "dpSettings";
            this.dpSettings.OriginalSize = new System.Drawing.Size(176, 200);
            this.dpSettings.Size = new System.Drawing.Size(176, 368);
            this.dpSettings.Text = "Settings";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.ucSetting);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(168, 341);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // ucSetting
            // 
            this.ucSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSetting.Location = new System.Drawing.Point(0, 0);
            this.ucSetting.Name = "ucSetting";
            this.ucSetting.Size = new System.Drawing.Size(168, 341);
            this.ucSetting.TabIndex = 0;
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.dpTimeLine;
            this.panelContainer1.Controls.Add(this.dpTimeLine);
            this.panelContainer1.Controls.Add(this.dpChannel);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.panelContainer1.FloatVertical = true;
            this.panelContainer1.ID = new System.Guid("f3b518da-9645-4baa-b6e9-a26dfb28f692");
            this.panelContainer1.ImageIndex = 5;
            this.panelContainer1.Location = new System.Drawing.Point(0, 367);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 148);
            this.panelContainer1.Size = new System.Drawing.Size(562, 148);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dpTimeLine
            // 
            this.dpTimeLine.Controls.Add(this.dockPanel2_Container);
            this.dpTimeLine.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dpTimeLine.FloatVertical = true;
            this.dpTimeLine.ID = new System.Guid("3641e904-815e-4bba-82b9-d3f2857a094c");
            this.dpTimeLine.ImageIndex = 5;
            this.dpTimeLine.Location = new System.Drawing.Point(4, 23);
            this.dpTimeLine.Name = "dpTimeLine";
            this.dpTimeLine.OriginalSize = new System.Drawing.Size(200, 200);
            this.dpTimeLine.Size = new System.Drawing.Size(554, 93);
            this.dpTimeLine.Text = "TimeLine";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.ucTimeLine);
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(554, 93);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // ucTimeLine
            // 
            this.ucTimeLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTimeLine.Location = new System.Drawing.Point(0, 0);
            this.ucTimeLine.Name = "ucTimeLine";
            this.ucTimeLine.Size = new System.Drawing.Size(554, 93);
            this.ucTimeLine.TabIndex = 0;
            // 
            // dpChannel
            // 
            this.dpChannel.Controls.Add(this.dockPanel3_Container);
            this.dpChannel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dpChannel.FloatVertical = true;
            this.dpChannel.ID = new System.Guid("b67bdf8e-3f8a-4dad-920c-5490159bf479");
            this.dpChannel.ImageIndex = 5;
            this.dpChannel.Location = new System.Drawing.Point(4, 23);
            this.dpChannel.Name = "dpChannel";
            this.dpChannel.OriginalSize = new System.Drawing.Size(200, 200);
            this.dpChannel.Size = new System.Drawing.Size(554, 93);
            this.dpChannel.Text = "Channel";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Controls.Add(this.ucChannel);
            this.dockPanel3_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(554, 93);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // ucChannel
            // 
            this.ucChannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucChannel.Location = new System.Drawing.Point(0, 0);
            this.ucChannel.Name = "ucChannel";
            this.ucChannel.Size = new System.Drawing.Size(554, 93);
            this.ucChannel.TabIndex = 0;
            // 
            // FxEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 546);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.dpSettings);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.mainRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FxEditor";
            this.Ribbon = this.mainRibbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Fx Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FxEditor_Closed);
            this.Load += new System.EventHandler(this.FxEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dockManager)).EndInit();
            this.dpSettings.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.panelContainer1.ResumeLayout(false);
            this.dpTimeLine.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.dpChannel.ResumeLayout(false);
            this.dockPanel3_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.Docking.DockManager m_dockManager;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel dpTimeLine;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dpChannel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraBars.Docking.DockPanel dpSettings;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.Utils.ImageCollection smallImages;
        private DevExpress.Utils.ImageCollection largeImages;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private FxChannel ucChannel;
        private FxTimeLine ucTimeLine;
        private FxSettings ucSetting;
    }
}