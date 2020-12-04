using PetWorld.GUI.UserControls.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            Load += (x, y) => LoadScreen(new Tab());
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
