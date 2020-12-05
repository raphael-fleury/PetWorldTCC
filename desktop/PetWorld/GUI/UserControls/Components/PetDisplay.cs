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
        private Action<Pet> editButtonClick;
        private Action<Pet> deleteButtonClick;

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
            editButton.Click += (x, y) => editButtonClick?.Invoke(pet);
            deleteButton.Click += (x, y) => deleteButtonClick?.Invoke(pet);
        }

        public PetDisplay(Pet pet) : this()
        {
            this.pet = pet;

            lblName.Text = pet.Nome;
            lblEspecie.Text += pet.Especie;
            lblRaca.Text += pet.Raca;
            lblResponsavel.Text += "";
            if (pet.Sexo == Sexo.FEMININO)
                sexIconBox.Image = Properties.Resources.Female;
        }
        #endregion
    }
}
