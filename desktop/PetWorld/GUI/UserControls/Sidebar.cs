using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetWorld.GUI.UserControls
{
    public partial class Sidebar : UserControl
    {
        public static Sidebar Instance { get; private set; }

        public static Sidebar Create()
        {
            Instance = new Sidebar();
            return Instance;
        }

        private Sidebar()
        {
            InitializeComponent();
        }  
    }
}
