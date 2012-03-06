﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace ArkEditor2.UI
{
    public partial class FxEditor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FxEditor()
        {
            InitializeComponent();
        }

        private void Close_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}