using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetWorld.GUI.UserControls.Components;
using PetWorld.GUI.Forms;
using PetWorld.Data.Repositories;
using PetWorld.Data.Entities;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class Clientes : Tab
    {
        public Clientes()
        {
            InitializeComponent();
            elements.FilterTextChanged += () => Reload(this, EventArgs.Empty);
        }

        private void Add(object sender, EventArgs e)
        {
            Main.LoadScreen(new ClientesForm(this));
        }

        public override void Reload(object sender, EventArgs e)
        {
            elements.Clear();

            var displays = ClientesRepository.FindAll()
                .Where(cliente => cliente.Nome.ToLower().Contains(elements.FilterText.ToLower()))
                .Select(cliente => new ClienteDisplay(cliente))
                .ToArray();

            foreach (var display in displays)
            {
                display.DetailsButtonClick += (cliente) =>
                    Main.LoadScreen(new ClienteDetails(this, cliente));
                display.EditButtonClick += (cliente) => 
                    Main.LoadScreen(new ClientesForm(this, cliente));
                display.DeleteButtonClick += (cliente) =>
                {
                    var result = MessageBox.Show("Deseja deletar " + cliente.Nome + "?", "Deletar Cliente", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                        ClientesRepository.DeleteById(cliente.Id.Value);
                    Reload(this, EventArgs.Empty);
                };
            }
            
            elements.Add(displays.ToArray());
        }
    }
}
