using System.Windows.Forms;
using PetWorld.GUI.UserControls.Components;
using PetWorld.GUI.UserControls.Screens;
using PetWorld.GUI.UserControls.Tabs;

namespace PetWorld.GUI.Forms
{
    public partial class Main : Form
    {
        public static Main Instance { get; private set; }
        public static Sidebar Sidebar => Instance.sidebar;
        
        public Tab ActualTab { get; private set; }

        public Tab HomeTab { get; } = new Tab(new Home());
        public PaginatedTab PetsTab { get; } = new PaginatedTab("Pets", null);
        public PaginatedTab ClientsTab { get; } = new PaginatedTab("Clients", null);

        public Main()
        {
            Instance = this;

            InitializeComponent();
            Home();
        }

        public void Home() { LoadTab(HomeTab); }
        public void Pets() { LoadTab(PetsTab); }
        public void Clients() { LoadTab(ClientsTab); }

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
            ActualTab = tab;
        }

        private void LoadTab(PaginatedTab tab, TabScreen screen)
        {
            LoadTab(tab);
            tab.Goto(screen);
        }
    }
}
