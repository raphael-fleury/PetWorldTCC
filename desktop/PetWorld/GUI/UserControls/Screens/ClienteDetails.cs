﻿using System;
using PetWorld.GUI.Forms;
using PetWorld.Data.Entities;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class ClienteDetails : TabScreen
    {
        public ClienteDetails(Cliente cliente)
        {
            InitializeComponent();

            lblTitle.Text = cliente.Nome;
            lblNome.Text = cliente.Nome;
            lblCPF.Text = cliente.CPF;
            lblTelefone.Text = cliente.Telefone;
            lblEndereco.Text = cliente.Endereco.ToString();
        }

        private void Return(object sender, EventArgs e)
        {
            Main.Instance.Clients();
        }
    }
}
