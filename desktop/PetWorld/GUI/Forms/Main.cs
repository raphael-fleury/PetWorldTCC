using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PetWorld.GUI.UserControls.Components;
using PetWorld.GUI.UserControls.Screens;
using PetWorld.GUI.UserControls.Tabs;

namespace PetWorld.GUI.Forms
{
    public partial class Main : Form
    {
        public static Main Instance { get; private set; }

        public Tab ActualTab => screen;

        public Tab HomeTab { get; } = new Tab(new Home());
        public PaginatedTab PetsTab { get; } = new PaginatedTab("Pets", new Pets());
        public PaginatedTab ClientsTab { get; } = new PaginatedTab("Clientes", new Clientes());

        private Color radioButtonsForeColor;

        public Main()
        {
            Instance = this;

            InitializeComponent();
            /*rbHome = new SidebarButton("Home", () => LoadTab(HomeTab));
            rbPets = new SidebarButton("Pets", () => LoadTab(HomeTab));
            rbCustomers = new SidebarButton("Clients", () => LoadTab(HomeTab));*/
            ConfigureButtons();
            Load += (sender, e) => Home();
        }

        public void Home() { rbHome.PerformClick(); }
        public void Pets() { rbPets.PerformClick(); }
        public void Clients() { rbCustomers.PerformClick(); }

        public void Pets(TabScreen screen) { LoadTab(PetsTab, screen); }
        public void Clients(TabScreen screen) { LoadTab(ClientsTab, screen); }

        private void LoadTab(Tab tab)
        {
            tab.Hide();
            Controls.Remove(screen);
            Controls.Add(tab);

            tab.BringToFront();
            tab.Dock = DockStyle.Fill;

            tab.TabIndex = screen.TabIndex;
            tab.Name = screen.Name;

            tab.Show();

            screen = tab;
        }

        private void LoadTab(PaginatedTab tab, TabScreen screen)
        {
            LoadTab(tab);
            tab.Goto(screen);
        }

        private void ConfigureButtons()
        {
            var tabs = new Dictionary<RadioButton, Action>
            {
                [rbHome] = () => LoadTab(HomeTab),
                [rbPets] = () => LoadTab(PetsTab),
                [rbCustomers] = () => LoadTab(ClientsTab)
            };

            radioButtonsForeColor = rbHome.ForeColor;
            foreach (var pair in tabs)
            {
                var button = pair.Key;
                button.CheckedChanged += (sender, args) =>
                {
                    button.Enabled = !button.Checked;

                    if (button.Checked)
                        pair.Value();
                };
                button.EnabledChanged += (x, y) =>
                    button.ForeColor = button.Checked ? Color.White : radioButtonsForeColor;
                button.Paint += (sender, e) =>
                {
                    RadioButton btn = (RadioButton)sender;
                    TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;                                                                                                                                             // render the text onto the button
                    TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, e.ClipRectangle, btn.ForeColor, flags);
                };
            }
        }
    }
}
