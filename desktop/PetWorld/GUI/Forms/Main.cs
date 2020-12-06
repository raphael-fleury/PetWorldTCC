using PetWorld.GUI.UserControls.Screens;
using System;
using System.Windows.Forms;

namespace PetWorld.GUI.Forms
{
    public partial class Main : Form
    {
        private static Main instance;

        public Main()
        {
            instance = this;
            InitializeComponent();
            Load += (x, y) => LoadScreen(new Home());
        }

        private void LoadTab(Tab control)
        {
            control.Hide();
            Controls.Remove(screen);
            Controls.Add(control);

            control.BringToFront();
            control.Dock = DockStyle.Fill;

            control.TabIndex = screen.TabIndex;
            control.Name = screen.Name;

            control.Show();
            screen = control;
        }

        public static void LoadScreen(Tab tab)
        {
            tab.Reload(instance, EventArgs.Empty);
            instance.sidebar.LoadScreen(tab);
            instance.LoadTab(tab);
        }
    }
}
