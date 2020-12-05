using System;
using PetWorld.GUI.Forms;
using PetWorld.Data.Entities;
using PetWorld.Data.Entities.Enums;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class PetDetails : Tab
    {
        private Tab callback;

        public PetDetails(Tab callback, Pet pet)
        {
            InitializeComponent();
            this.callback = callback;

            title.Text = pet.Nome;
            lbNome.Text = pet.Nome;
            lbEspecie.Text = pet.Especie;
            lbRaca.Text = pet.Raca;
            lbCastrado.Text = pet.Castrado ? "Sim" : "Não";
            if (pet.Sexo == Sexo.MASCULINO)
                lbSexo.Text = "Masculino";
            else if (pet.Sexo == Sexo.FEMININO)
                lbSexo.Text = "Feminino";
        }

        private void Return(object sender, EventArgs e)
        {
            Main.LoadScreen(callback ?? new Pets());
        }
    }
}
