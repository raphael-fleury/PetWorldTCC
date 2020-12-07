using PetWorld.Data.Entities;
using PetWorld.GUI.Forms;
using System.Windows.Forms;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class Selector<T> : Tab
    {
        private Tab callback;
        private T response;

        public Selector(Tab callback, Tab menu)
        {
            InitializeComponent();
            this.callback = callback;
            LoadMenu(menu);
        }

        private void LoadMenu(Tab menu)
        {
            menu.Hide();
            Controls.Remove(this.menu);
            Controls.Add(menu);

            menu.BringToFront();
            menu.Dock = DockStyle.Fill;

            menu.TabIndex = this.menu.TabIndex;
            menu.Name = this.menu.Name;

            menu.Show();
            this.menu = menu;
        }

        #region Button Events
        private void Return(object sender, System.EventArgs e)
        {
            Main.LoadScreen(callback);
        }

        private void Done(object sender, System.EventArgs e)
        {
            if (callback is IRequester<T>)
            {
                var requester = callback as IRequester<T>;
                requester.Respond(response);
            }
            Main.LoadScreen(callback);
        }
        #endregion
    }
}
