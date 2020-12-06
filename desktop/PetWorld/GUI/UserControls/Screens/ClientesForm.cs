using System;
using PetWorld.GUI.Forms;
using PetWorld.Data.Entities;
using PetWorld.Data.Repositories;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class ClientesForm : Tab
    {
        #region Fields
        private Tab callback;

        private uint? clienteId;
        #endregion

        private bool fieldsAreValid => !string.IsNullOrEmpty(txtNome.Text)
            && !string.IsNullOrEmpty(txtTelefone.Text);

        #region Constructors
        public ClientesForm(Tab callback)
        {
            InitializeComponent();
            this.callback = callback;

            Load += (x, y) => btDone.Enabled = fieldsAreValid;
            txtNome.TextChanged += (x, y) => btDone.Enabled = fieldsAreValid;
            txtCPF.TextChanged += (x, y) => btDone.Enabled = fieldsAreValid;
            txtTelefone.TextChanged += (x, y) => btDone.Enabled = fieldsAreValid;
        }

        public ClientesForm(Tab callback, Cliente cliente) : this(callback)
        {
            title.Text = "Editar Cliente";

            clienteId = cliente.Id;
            txtNome.Text = cliente.Nome;
            txtCPF.Text = cliente.CPF;
            txtTelefone.Text = cliente.Telefone;
            txtEndereco.Text = cliente.Endereco;
        }
        #endregion

        #region Button Events
        private void Return(object sender, EventArgs e)
        {
            Main.LoadScreen(callback ?? new Clientes());
        }

        private void Done(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNome.Text, txtCPF.Text, txtTelefone.Text, txtEndereco.Text);
            cliente.Id = clienteId;
            ClientesRepository.Save(cliente);

            Return(sender, e);
        }
        #endregion
    }
}
