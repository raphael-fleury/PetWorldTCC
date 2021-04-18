using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PetWorld.GUI.UserControls.Screens;

namespace PetWorld.GUI.UserControls.Tabs
{
    public partial class PaginatedTab : Tab
    {
        public Stack<TabScreen> Screens { get; } = new Stack<TabScreen>();

        public override TabScreen ActualScreen => Screens.Peek();

        public bool CanReturn => Screens.Count > 1;

        #region Constructors
        public PaginatedTab() => InitializeComponent();

        public PaginatedTab(TabScreen root) : this()
        {
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
            if (!CanReturn)
                return;

            Screens.Pop();
            OnPageChange();
        }

        private void OnPageChange()
        {
            LoadScreen(ActualScreen);
            btnReturn.Enabled = CanReturn;
        }

        protected override void LoadScreen(TabScreen tabScreen)
        {
            /*header.Controls.Clear();
            foreach (var control in tabScreen.Header.Controls)
            {
                header.Controls.Add((Control)control);
            }*/
            tabScreen.Controls.Remove(tabScreen.Header);
            base.LoadScreen(tabScreen);
        }
    }
}
