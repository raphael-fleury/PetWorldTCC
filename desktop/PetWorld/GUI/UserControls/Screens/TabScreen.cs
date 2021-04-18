using System;
using System.Windows.Forms;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class TabScreen : UserControl
    {
        public virtual Panel Header { get; }

        public TabScreen() => InitializeComponent();

        public TabScreen(string name) : this()
        {
            Name = name;
        }

        protected virtual void Reload(object sender, EventArgs e) { }
    }
}
