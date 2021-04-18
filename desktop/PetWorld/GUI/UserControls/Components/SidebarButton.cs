using System.Drawing;
using System.Windows.Forms;

namespace PetWorld.GUI.UserControls.Components
{
    class SidebarButton : RadioButton
    {
        private Color defaultForeColor;

        public SidebarButton() : base()
        {
            defaultForeColor = ForeColor;

            ConfigureEvents();
        }

        private void ConfigureEvents()
        {
            EnabledChanged += (x, y) => ForeColor = Checked ? Color.White : defaultForeColor;

            Paint += (sender, e) =>
            {
                RadioButton btn = (RadioButton)sender;
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak;                                                                                                                                             // render the text onto the button
                TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, e.ClipRectangle, btn.ForeColor, flags);
            };
        }
    }
}
