using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace ArkEditor2.UI
{
    public partial class StartPage : DevExpress.XtraEditors.XtraUserControl
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            LookAndFeel.StyleChanged += new EventHandler(StartPage_StyleChanged);
        }

        private void StartPage_StyleChanged(object sender, EventArgs e)
        {
            Skin skin = CommonSkins.GetSkin(UserLookAndFeel.Default);
            SkinElement element = skin[CommonSkins.SkinGroupPanel];
            Color pixel = ((Bitmap)element.Image.Image).GetPixel(4, 4);
            this.BackColor = pixel;
        }
    }
}
