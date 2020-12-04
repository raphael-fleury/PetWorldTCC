using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetWorld.GUI.UserControls.Components
{
    public partial class ElementsDisplay : UserControl
    {
        public string FilterText => txtFilter.Text;

        public ElementsDisplay()
        {
            InitializeComponent();
        }

        public void Clear() => panel.Controls.Clear();

        public void Add(Control control)
        {
            panel.Controls.Add(control);
        }

        public void Add(Control[] controls)
        {
            panel.Controls.AddRange(controls);
        }

        private void OnResize(object sender, EventArgs e)
        {

        }
    }
}
