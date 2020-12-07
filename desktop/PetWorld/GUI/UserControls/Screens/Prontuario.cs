using PetWorld.Data.Entities;
using System;
using System.Windows.Forms;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class Prontuario : Tab
    {
        public Prontuario(Pet pet)
        {
            InitializeComponent();
            lbNome.Text += pet.Nome;
        }
    }
}
