using System;
using PetWorld.GUI.Forms;
using PetWorld.Data.Entities;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class ClienteDetails : Tab
    {
        private Tab callback;

        public ClienteDetails(Tab callback, Cliente cliente)
        {
            InitializeComponent();
            this.callback = callback;

            title.Text = cliente.Nome;
            lbNome.Text = cliente.Nome;
            lbCPF.Text = cliente.CPF;
            lbTelefone.Text = cliente.Telefone;
            lbEndereco.Text = cliente.Endereco.ToString();
        }

        private void Return(object sender, EventArgs e)
        {
            Main.LoadScreen(callback ?? new Clientes());
        }
    }
}
