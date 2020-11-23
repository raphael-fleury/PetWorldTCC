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
        public ElementsDisplay()
        {
            InitializeComponent();
        }

        public void Add(Control control)
        {
            items.Controls.Add(control);
        }

        private void OnResize(object sender, EventArgs e)
        {

        }
    }
}
