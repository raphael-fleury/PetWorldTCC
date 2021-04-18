using System.Windows.Forms;
using PetWorld.GUI.UserControls.Screens;

namespace PetWorld.GUI.UserControls.Tabs
{
    public partial class Tab : UserControl
    {
        public virtual TabScreen ActualScreen => screen;

        public Tab() => InitializeComponent();

        public Tab(TabScreen screen) : this()
        {
            Load += (sender, e) => { this.screen = screen; };
        }
    }
}
