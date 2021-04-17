using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using PetWorld.GUI.Forms;

namespace PetWorld.GUI.UserControls.Components
{
    public partial class Sidebar : UserControl
    {
        private Color radioButtonsForeColor;
        private Dictionary<RadioButton, Action> tabs;

        public Sidebar()
        {
            InitializeComponent();
            ConfigureButtons();
        }

        private void ConfigureButtons()
        {
            tabs = new Dictionary<RadioButton, Action>
            {
                [rbHome] = Main.Instance.Home,
                [rbPets] = Main.Instance.Pets,
                [rbClientes] = Main.Instance.Clients
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
