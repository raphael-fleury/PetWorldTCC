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
            Load += (sender, e) => { LoadScreen(screen); };
        }

        protected virtual void LoadScreen(TabScreen tabScreen)
        {
            tabScreen.Hide();
            Controls.Remove(screen);
            Controls.Add(tabScreen);

            tabScreen.BringToFront();
            tabScreen.Dock = DockStyle.Fill;

            tabScreen.TabIndex = screen.TabIndex;
            tabScreen.Name = screen.Name;

            tabScreen.Show();

            screen = tabScreen;
        }
    }
}
