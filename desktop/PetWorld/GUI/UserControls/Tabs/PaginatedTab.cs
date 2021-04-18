using PetWorld.GUI.UserControls.Screens;
using System.Collections.Generic;

namespace PetWorld.GUI.UserControls.Tabs
{
    public partial class PaginatedTab : Tab
    {
        public Stack<TabScreen> Screens { get; } = new Stack<TabScreen>();

        public override TabScreen ActualScreen => Screens.Peek();

        #region Constructors
        public PaginatedTab() => InitializeComponent();

        public PaginatedTab(string name, TabScreen root) : this()
        {
            lblTitle.Text = name;
            Load += (sender, e) => Goto(root);
        }
        #endregion

        public void Goto(TabScreen screen)
        {
            Screens.Push(screen);
            OnPageChange();
        }

        public void Return()
        {
            if (Screens.Count < 2)
                return;

            Screens.Pop();
            OnPageChange();
        }

        private void OnPageChange()
        {
            LoadScreen(ActualScreen);
            lblTitle.Text = ActualScreen.Name;
        }
    }
}
