using System;
using System.Windows.Forms;
using PetWorld.Data.Entities;
using PetWorld.Data.Entities.Enums;

namespace PetWorld.GUI.UserControls.Components
{
    public partial class CardCliente : UserControl
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
        public CardCliente()
        {
            InitializeComponent();
            detailsButton.Click += (x, y) => detailsButtonClick?.Invoke(cliente);
            editButton.Click += (x, y) => editButtonClick?.Invoke(cliente);
            deleteButton.Click += (x, y) => deleteButtonClick?.Invoke(cliente);
        }

        public CardCliente(Cliente cliente) : this()
        {
            this.cliente = cliente;

            lbNome.Text = cliente.Nome;
            lbEndereco.Text += cliente.Endereco;
            lbTelefone.Text += cliente.Telefone;
        }
        #endregion
    }
}
