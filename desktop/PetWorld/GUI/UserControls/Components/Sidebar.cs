using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PetWorld.GUI.Forms;
using PetWorld.GUI.UserControls.Screens;

namespace PetWorld.GUI.UserControls.Components
{
    public partial class Sidebar : UserControl
    {
        private Color radioButtonsForeColor;
        private Dictionary<RadioButton, Tab> tabs;

        public Sidebar()
        {
            InitializeComponent();

            tabs = new Dictionary<RadioButton, Tab>
            {
                [rbHome] = new Home(),
                [rbPets] = new Pets(),
                [rbClientes] = new Clientes()
            };

            radioButtonsForeColor = rbHome.ForeColor;
            foreach (var pair in tabs)
            {
                var button = pair.Key;
                button.CheckedChanged += (sender, args) =>
                {
                    button.Enabled = !button.Checked;

                    if (button.Checked)
                        Main.LoadScreen(pair.Value);
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

        public void LoadScreen(Tab tab)
        {
            foreach (var pair in tabs)
            {
                if (tab.GetType() == pair.Value.GetType())
                {
                    tabs[pair.Key] = tab;
                    pair.Key.PerformClick();
                    return;
                }
            }
        }
    }
}
