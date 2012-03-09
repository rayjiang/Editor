using System;
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
using DevExpress.XtraSplashScreen;
using DevExpress.XtraBars.Docking2010.Views;
using ArkEditor2.Interface;

namespace ArkEditor2.UI
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private EditorFramework m_framework;

        private BaseDocument m_startPage;
        private BaseDocument m_config;
        private BaseDocument m_revisionLog;
        private SceneEditor m_sceneEditor;
        private FxEditor m_fxEditor;
        private SceneWalker m_sceneWalker;

        public MainForm()
        {
            m_framework = new EditorFramework();

            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            
            InitializeComponent();

            // workaround for maximized RibbonForm
            dockManager.ForceInitialize();
            mainRibbon.ForceInitialize();
            mainRibbon.Manager.DockManager = dockManager;

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

        void TabbedView_EndFloating(object sender, DocumentEventArgs e)
        {
            if (e.Document.Caption == "Fx Editor")
            {
                FxEditor fx = e.Document.Form as FxEditor;
                fx.UndockFromMainForm();
            }
            else if (e.Document.Caption == "Scene Editor")
            {
                //SceneEditor scene = e.Document.Form as SceneEditor;
                //scene.UndockFromMainForm();
            }
        }

        void TabbedView_DocumentRemoved(object sender, DocumentEventArgs e)
        {

        }

        void TabbedView_DocumentAdded(object sender, DocumentEventArgs e)
        {
            if (e.Document.Caption == "Fx Editor")
            {
                FxEditor fx = e.Document.Form as FxEditor;
                fx.DockToMainForm(dockManager);
            }
            else if (e.Document.Caption == "Scene Editor")
            {
                //SceneEditor scene = e.Document.Form as SceneEditor;
                //scene.DockToMainForm(dockManager);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Merge Style
            this.mainRibbon.MdiMergeStyle = RibbonMdiMergeStyle.Always;

            // Init Gallery
            InitModuleGallery(moduleGallery.Gallery.Groups[0]);
            InitToolsGallery(toolGallery.Gallery.Groups[0]);

            // Init Tabbed View
            tabbedView.DocumentAdded += new DocumentEventHandler(TabbedView_DocumentAdded);
            tabbedView.DocumentRemoved += new DocumentEventHandler(TabbedView_DocumentRemoved);
            tabbedView.EndFloating += new DocumentEventHandler(TabbedView_EndFloating);
            tabbedView.BeginUpdate();

            // Add document
            //AddStartPageDocument();
            //AddConfigDocument();
            //AddRevisionLogDocument();

            //tabbedView.Controller.Activate(m_startPage);
            tabbedView.EndUpdate();
        }

        private void InitModuleGallery(GalleryItemGroup groupDropDown)
        {
            string[] names = m_framework.GetModuleNames();
            foreach (string name in names)
            {
                IModule m = m_framework.GetModuleInterface(name);
                GalleryItem item = new GalleryItem();
                item.Tag = m;
                item.Caption = m.ModuleCaption;
                item.Description = m.ModuleDescription;
                item.Image = m.ModuleLargeGlyph;
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
            SplashScreenManager.ShowForm(typeof(ModuleWaitForm));

            IModule m = e.Item.Tag as IModule;
            BaseDocument doc = documentManager.GetDocument(m.ModuleForm);

            if (doc == null)
            {
                m.ModuleForm.MdiParent = this;
                m.ModuleForm.Show();
            }
            else
            {
                if (m.ModuleForm.WindowState == FormWindowState.Minimized)
                    m.ModuleForm.WindowState = FormWindowState.Normal;
                m.ModuleForm.Activate();
            }

            SplashScreenManager.CloseForm();

            /*
            if (string.Compare(e.Item.Caption, "Scene Editor", true) == 0)
            {
                if (m_sceneEditor == null || m_sceneEditor.IsDisposed)
                {
                    SplashScreenManager.ShowForm(typeof(ModuleWaitForm));

                    m_sceneEditor = new SceneEditor();
                    m_sceneEditor.Text = "Scene Editor";
                    m_sceneEditor.MdiParent = this;
                    m_sceneEditor.Show();

                    SplashScreenManager.CloseForm();
                }
                else
                {
                    BaseDocument doc = documentManager.GetDocument(m_sceneEditor);
                    tabbedView.Controller.Activate(doc);
                }
            }
            else if (string.Compare(e.Item.Caption, "Fx Editor", true) == 0)
            {
                if (m_fxEditor == null || m_fxEditor.IsDisposed)
                {
                    SplashScreenManager.ShowForm(typeof(ModuleWaitForm));

                    m_fxEditor = new FxEditor();
                    m_fxEditor.Text = "Fx Editor";
                    m_fxEditor.MdiParent = this;
                    m_fxEditor.Show();

                    SplashScreenManager.CloseForm();
                }
                else
                {
                    BaseDocument doc = documentManager.GetDocument(m_fxEditor);
                    tabbedView.Controller.Activate(doc);

                    //m_fxEditor.Activate();
                }
            }
            else if (string.Compare(e.Item.Caption, "Scene Walker", true) == 0)
            {
                if (m_sceneWalker == null || m_sceneWalker.IsDisposed)
                {
                    SplashScreenManager.ShowForm(typeof(ModuleWaitForm));

                    m_sceneWalker = new SceneWalker();
                    m_sceneWalker.Text = "Scene Walker";
                    m_sceneWalker.MdiParent = this;
                    m_sceneWalker.Show();

                    SplashScreenManager.CloseForm();
                }
                else
                {
                    BaseDocument doc = documentManager.GetDocument(m_sceneWalker);
                    tabbedView.Controller.Activate(doc);
                }
            }
             * */
        }

        private void MainRibbon_Merge(object sender, RibbonMergeEventArgs e)
        {
            RibbonControl main = sender as RibbonControl;
            RibbonControl child = e.MergedChild;

            if (e.MergedChild.Pages.Count > 0)
                main.SelectedPage = child.Pages[0];

            // merge status bar
            main.StatusBar.MergeStatusBar(child.StatusBar);
        }

        private void MainRibbon_UnMerge(object sender, RibbonMergeEventArgs e)
        {
            // un-merge status bar
            RibbonControl main = sender as RibbonControl;
            main.StatusBar.UnMergeStatusBar();
        }

    }
}