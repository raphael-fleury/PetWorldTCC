using System;
using System.Drawing;
using System.Windows.Forms;

namespace PetWorld.GUI.UserControls.Components
{
    public class SidebarButton : RadioButton
    {
        private Color defaultForeColor;

        public SidebarButton() : base() { }

        public SidebarButton(string text, Action onClickAction) : this()
        {
            Text = text;
            defaultForeColor = ForeColor;

            CheckedChanged += (sender, args) =>
            {
                Enabled = !Checked;

                if (Checked)
                    onClickAction();
            };

            EnabledChanged += (x, y) =>
                    ForeColor = Checked ? Color.White : defaultForeColor;

            Paint += (sender, e) =>
            {
                RadioButton btn = (RadioButton)sender;
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;                                                                                                                                             // render the text onto the button
                TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, e.ClipRectangle, btn.ForeColor, flags);
            };
        }
    }
}
