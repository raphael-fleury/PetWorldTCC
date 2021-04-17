using PetWorld.GUI.UserControls.Screens;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PetWorld.GUI.UserControls.Tabs
{
    public partial class PaginatedTab : Tab
    {
        public Stack<TabScreen> Screens { get; } = new Stack<TabScreen>();

        public TabScreen Actual => Screens.Peek();

        #region Constructors
        public PaginatedTab() => InitializeComponent();

        public PaginatedTab(string name, TabScreen root) : this()
        {
            title.Text = name;
            Goto(root);
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
            screen = Actual;
        }
    }
}
