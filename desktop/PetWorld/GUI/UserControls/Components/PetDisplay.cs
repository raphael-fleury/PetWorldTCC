using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetWorld.Data.Entities;

namespace PetWorld.GUI.UserControls.Components
{
    public partial class PetDisplay : UserControl
    {
        public PetDisplay()
        {
            InitializeComponent();
        }

        public PetDisplay(Pet pet) : this()
        {
            lblName.Text = pet.Nome;
            lblEspecie.Text += pet.Especie;
            lblRaca.Text += pet.Raca;
            lblResponsavel.Text += "";
        }
    }
}
