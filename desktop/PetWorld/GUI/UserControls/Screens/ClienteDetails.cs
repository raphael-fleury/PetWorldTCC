using System;
using PetWorld.GUI.Forms;
using PetWorld.Data.Entities;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class ClienteDetails : TabScreen
    {
        public ClienteDetails(Cliente cliente)
        {
            InitializeComponent();

            title.Text = cliente.Nome;
            lbNome.Text = cliente.Nome;
            lbCPF.Text = cliente.CPF;
            lbTelefone.Text = cliente.Telefone;
            lbEndereco.Text = cliente.Endereco.ToString();
        }

        private void Return(object sender, EventArgs e)
        {
            Main.Instance.Clients();
        }
    }
}
