using System;
using PetWorld.GUI.Forms;
using PetWorld.Data.Entities;
using PetWorld.Data.Entities.Enums;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class PetDetails : TabScreen
    {
        private Pet pet;

        public PetDetails(Pet pet)
        {
            InitializeComponent();
            this.pet = pet;

            lblTitle.Text = pet.Nome;
            lblNome.Text = pet.Nome;
            lblEspecie.Text = pet.Especie;
            lblRaca.Text = pet.Raca;
            lblCastrado.Text = pet.Castrado ? "Sim" : "Não";
            if (pet.Sexo == Sexo.MASCULINO)
                lblSexo.Text = "Masculino";
            else if (pet.Sexo == Sexo.FEMININO)
                lblSexo.Text = "Feminino";
        }

        private void Return(object sender, EventArgs e)
        {
            Main.Instance.PetsTab.Return();
        }

        private void ShowProntuario(object sender, EventArgs e)
        {
            Main.Instance.Pets(new Prontuario(pet));
        }
    }
}
