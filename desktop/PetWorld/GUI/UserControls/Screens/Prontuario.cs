using PetWorld.Data.Entities;
using System.Windows.Forms;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class Prontuario : TabScreen
    {
        public override Panel Header => null;

        public Prontuario(Pet pet)
        {
            InitializeComponent();
            lbNome.Text += pet.Nome;
        }
    }
}
