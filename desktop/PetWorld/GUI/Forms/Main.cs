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
        public static Main Instance { get; private set; }

        public static void Create() { Instance = new Main(); }

        private Main()
        {
            Instance = this;
            InitializeComponent();
            Load += (x, y) => sidebar.LoadScreen(new UserControls.UserControl1());
        }

        public void LoadScreen(UserControls.Screen control)
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
    }
}
