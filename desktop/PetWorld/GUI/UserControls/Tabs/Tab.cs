using PetWorld.GUI.UserControls.Screens;
using System.Windows.Forms;

namespace PetWorld.GUI.UserControls.Tabs
{
    public partial class Tab : UserControl
    {
        public TabScreen ActualScreen { get; private set; }

        public Tab() => InitializeComponent();

        public Tab(TabScreen screen) : this()
        {
            ActualScreen = screen;
            this.screen = screen;
        }
    }
}
