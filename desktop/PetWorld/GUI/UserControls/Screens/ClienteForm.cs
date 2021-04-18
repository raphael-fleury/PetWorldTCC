using System;
using System.Linq;
using PetWorld.GUI.Forms;
using PetWorld.Data.Entities;
using PetWorld.Data.Repositories;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class ClienteForm : TabScreen
    {
        private uint? clienteId;

        private bool fieldsAreValid => !string.IsNullOrEmpty(txtNome.Text)
            && txtTelefone.Text.Where(c => char.IsNumber(c)).ToArray().Length > 0
            && enderecoForm.FieldsAreValid;

        #region Constructors
        public ClienteForm()
        {
            InitializeComponent();

            Load += (x, y) => btnDone.Enabled = fieldsAreValid;
            txtNome.TextChanged += (x, y) => btnDone.Enabled = fieldsAreValid;
            txtCPF.TextChanged += (x, y) => btnDone.Enabled = fieldsAreValid;
            txtTelefone.TextChanged += (x, y) => btnDone.Enabled = fieldsAreValid;
            enderecoForm.FieldsChanged += () => btnDone.Enabled = fieldsAreValid;
        }

        public ClienteForm(Cliente cliente) : this()
        {
            title.Text = "Editar Cliente";

            clienteId = cliente.Id;
            txtNome.Text = cliente.Nome;
            txtCPF.Text = cliente.CPF;
            txtTelefone.Text = cliente.Telefone;
            enderecoForm.Endereco = cliente.Endereco;
        }
        #endregion

        #region Button Events
        private void Return(object sender, EventArgs e)
        {
            Main.Instance.ClientsTab.Return();
        }

        private void Done(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
                txtNome.Text,
                txtCPF.Text,
                txtTelefone.Text,
                enderecoForm.Endereco
            );
            cliente.Id = clienteId;
            ClientesRepository.Save(cliente);

            Return(sender, e);
        }
        #endregion
    }
}
