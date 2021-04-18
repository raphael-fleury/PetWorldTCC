using PetWorld.Data.Entities;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class Prontuario : TabScreen
    {
        public Prontuario(Pet pet)
        {
            InitializeComponent();
            lbNome.Text += pet.Nome;
        }
    }
}
