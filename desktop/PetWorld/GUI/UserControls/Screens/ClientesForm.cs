using System;
using System.Linq;
using PetWorld.GUI.Forms;
using PetWorld.Data.Entities;
using PetWorld.Data.Repositories;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class ClientesForm : TabScreen
    {
        private uint? clienteId;

        private bool fieldsAreValid => !string.IsNullOrEmpty(txtNome.Text)
            && txtTelefone.Text.Where(c => char.IsNumber(c)).ToArray().Length > 0
            && enderecoForm.FieldsAreValid;

        #region Constructors
        public ClientesForm()
        {
            InitializeComponent();

            Load += (x, y) => btDone.Enabled = fieldsAreValid;
            txtNome.TextChanged += (x, y) => btDone.Enabled = fieldsAreValid;
            txtCPF.TextChanged += (x, y) => btDone.Enabled = fieldsAreValid;
            txtTelefone.TextChanged += (x, y) => btDone.Enabled = fieldsAreValid;
            enderecoForm.FieldsChanged += () => btDone.Enabled = fieldsAreValid;
        }

        public ClientesForm(Cliente cliente) : this()
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
