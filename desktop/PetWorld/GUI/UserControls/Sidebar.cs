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

namespace PetWorld.GUI.UserControls
{
    public partial class Sidebar : UserControl
    {
        private Color radioButtonsForeColor;
        private Dictionary<RadioButton, Screen> tabs;

        public Sidebar()
        {
            InitializeComponent();

            tabs = new Dictionary<RadioButton, Screen>
            {
                [rbHome] = new UserControl1(),
                [rbPets] = new Pets()
            };

            radioButtonsForeColor = rbHome.ForeColor;
            foreach (var pair in tabs)
            {
                var button = pair.Key;
                button.CheckedChanged += (x, y) =>
                {
                    button.Enabled = !button.Checked;

                    if (button.Checked)
                        Main.Instance.LoadScreen(pair.Value);
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

        public void LoadScreen(Screen screen)
        {
            foreach (var pair in tabs)
            {               
                if (screen.GetType() == pair.Value.GetType())
                {
                    tabs[pair.Key] = screen;
                    pair.Key.PerformClick();
                    return;
                }
            }
        }
    }
}
