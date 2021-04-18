using System;
using System.Windows.Forms;
using PetWorld.Data.Entities;
using PetWorld.Data.Entities.Enums;

namespace PetWorld.GUI.UserControls.Components
{
    public partial class ClienteDisplay : UserControl
    {
        private Cliente cliente;

        #region Events
        private Action<Cliente> detailsButtonClick;
        private Action<Cliente> editButtonClick;
        private Action<Cliente> deleteButtonClick;

        public event Action<Cliente> DetailsButtonClick
        {
            add { detailsButtonClick += value; }
            remove { detailsButtonClick -= value; }
        }

        public event Action<Cliente> EditButtonClick
        {
            add { editButtonClick += value; }
            remove { editButtonClick -= value; }
        }

        public event Action<Cliente> DeleteButtonClick
        {
            add { deleteButtonClick += value; }
            remove { deleteButtonClick -= value; }
        }
        #endregion

        #region Constructors
        public ClienteDisplay()
        {
            InitializeComponent();
            btnDetails.Click += (x, y) => detailsButtonClick?.Invoke(cliente);
            btnEdit.Click += (x, y) => editButtonClick?.Invoke(cliente);
            btnDelete.Click += (x, y) => deleteButtonClick?.Invoke(cliente);
        }

        public ClienteDisplay(Cliente cliente) : this()
        {
            this.cliente = cliente;

            lblNome.Text = cliente.Nome;
            lblEndereco.Text += cliente.Endereco;
            lblTelefone.Text += cliente.Telefone;
        }
        #endregion
    }
}
