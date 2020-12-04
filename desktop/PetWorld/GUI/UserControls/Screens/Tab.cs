using System;
using System.Windows.Forms;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class Tab : UserControl
    {
        public Tab()
        {
            InitializeComponent();
        }

        public virtual void Reload(object sender, EventArgs e) { }
    }
}
