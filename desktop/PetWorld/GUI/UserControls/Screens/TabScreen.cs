using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class TabScreen : UserControl
    {
        public TabScreen()
        {
            InitializeComponent();
        }

        public virtual void Reload(object sender, EventArgs e) { }
    }
}
