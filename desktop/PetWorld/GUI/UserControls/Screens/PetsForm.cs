using System;
using PetWorld.GUI.Forms;
using PetWorld.Data.Entities;
using PetWorld.Data.Entities.Enums;
using PetWorld.Data.Repositories;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class PetsForm : Tab
    {
        #region Fields
        private Tab callback;

        private uint? petId;
        private Cliente petResponsavel;
        #endregion

        private bool fieldsAreValid => !string.IsNullOrEmpty(txtNome.Text)
            && !string.IsNullOrEmpty(txtEspecie.Text)
            && !string.IsNullOrEmpty(txtRaca.Text);

        #region Constructors
        public PetsForm(Tab callback)
        {
            InitializeComponent();
            this.callback = callback;

            Load += (x, y) => btDone.Enabled = fieldsAreValid;
            txtNome.TextChanged += (x, y) => btDone.Enabled = fieldsAreValid;
            txtEspecie.TextChanged += (x, y) => btDone.Enabled = fieldsAreValid;
            txtRaca.TextChanged += (x, y) => btDone.Enabled = fieldsAreValid;
        }

        public PetsForm(Tab callback, Pet pet) : this(callback)
        {
            title.Text = "Editar Pet";

            Console.WriteLine(pet.Id);
            petId = pet.Id;
            txtNome.Text = pet.Nome;
            txtEspecie.Text = pet.Especie;
            txtRaca.Text = pet.Raca;
            cbCastrado.Checked = pet.Castrado;
            if (pet.Sexo == Sexo.FEMININO)
                rbFeminino.Checked = true;
            petResponsavel = pet.Responsavel;
        }
        #endregion

        #region Button Events
        private void Return(object sender, EventArgs e)
        {
            Main.LoadScreen(callback ?? new Pets());
        }

        private void Done(object sender, EventArgs e)
        {
            Sexo sexo = rbMasculino.Checked ? Sexo.MASCULINO : Sexo.FEMININO;
            Pet pet = new Pet(
                txtNome.Text,
                txtEspecie.Text,
                txtRaca.Text,
                cbCastrado.Checked,
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
