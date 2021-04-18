using System;
using PetWorld.GUI.Forms;
using PetWorld.Data.Entities;
using PetWorld.Data.Entities.Enums;
using PetWorld.Data.Repositories;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class PetsForm : TabScreen
    {
        private uint? petId;
        private Cliente petResponsavel;

        private bool fieldsAreValid => !string.IsNullOrEmpty(txtNome.Text)
            && !string.IsNullOrEmpty(txtEspecie.Text)
            && !string.IsNullOrEmpty(txtRaca.Text);

        #region Constructors
        public PetsForm()
        {
            InitializeComponent();
            ConfigureEvents();
        }

        public PetsForm(Pet pet) : this()
        {
            SetPet(pet);
        }
        #endregion

        #region Initialization
        private void ConfigureEvents()
        {
            Load += (x, y) => btnDone.Enabled = fieldsAreValid;
            txtNome.TextChanged += (x, y) => btnDone.Enabled = fieldsAreValid;
            txtEspecie.TextChanged += (x, y) => btnDone.Enabled = fieldsAreValid;
            txtRaca.TextChanged += (x, y) => btnDone.Enabled = fieldsAreValid;
        }

        private void SetPet(Pet pet)
        {
            title.Text = "Editar Pet";

            Console.WriteLine(pet.Id);
            petId = pet.Id;
            petResponsavel = pet.Responsavel;

            txtNome.Text = pet.Nome;
            txtEspecie.Text = pet.Especie;
            txtRaca.Text = pet.Raca;
            chkCastrado.Checked = pet.Castrado;
            if (pet.Sexo == Sexo.FEMININO)
                rbFeminino.Checked = true;
        }
        #endregion

        #region Button Events
        private void Return(object sender, EventArgs e)
        {
            Main.Instance.PetsTab.Return();
        }

        private void Done(object sender, EventArgs e)
        {
            Sexo sexo = rbMasculino.Checked ? Sexo.MASCULINO : Sexo.FEMININO;
            Pet pet = new Pet(
                txtNome.Text,
                txtEspecie.Text,
                txtRaca.Text,
                chkCastrado.Checked,
                sexo,
                petResponsavel
            );
            pet.Id = petId;
            PetsRepository.Save(pet);

            Return(sender, e);
        }
        #endregion
    }
}
