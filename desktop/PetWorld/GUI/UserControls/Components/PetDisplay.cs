using System;
using System.Windows.Forms;
using PetWorld.Data.Entities;
using PetWorld.Data.Entities.Enums;

namespace PetWorld.GUI.UserControls.Components
{
    public partial class PetDisplay : UserControl
    {
        private Pet pet;

        #region Events
        private Action<Pet> detailsButtonClick;
        private Action<Pet> editButtonClick;
        private Action<Pet> deleteButtonClick;

        public event Action<Pet> DetailsButtonClick
        {
            add { detailsButtonClick += value; }
            remove { detailsButtonClick -= value; }
        }

        public event Action<Pet> EditButtonClick
        {
            add { editButtonClick += value; }
            remove { editButtonClick -= value; }
        }

        public event Action<Pet> DeleteButtonClick
        {
            add { deleteButtonClick += value; }
            remove { deleteButtonClick -= value; }
        }
        #endregion

        #region Constructors
        public PetDisplay()
        {
            InitializeComponent();
            btnDetails.Click += (x, y) => detailsButtonClick?.Invoke(pet);
            btnEdit.Click += (x, y) => editButtonClick?.Invoke(pet);
            btnDelete.Click += (x, y) => deleteButtonClick?.Invoke(pet);
        }

        public PetDisplay(Pet pet) : this()
        {
            this.pet = pet;

            lblNome.Text = pet.Nome;
            lblEspecie.Text += pet.Especie;
            lblRaca.Text += pet.Raca;
            lblResponsavel.Text += "";
            if (pet.Sexo == Sexo.FEMININO)
                sexIconBox.Image = Properties.Resources.Female;
        }
        #endregion
    }
}
