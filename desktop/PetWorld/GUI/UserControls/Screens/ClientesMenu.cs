using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PetWorld.GUI.UserControls.Components;
using PetWorld.GUI.Forms;
using PetWorld.Data.Repositories;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class ClientesMenu : TabScreen
    {
        public override Panel Header => header;

        public ClientesMenu()
        {
            InitializeComponent();
            elements.FilterTextChanged += () => Reload(this, EventArgs.Empty);
        }

        private void Add(object sender, EventArgs e)
        {
            Main.Instance.Clients(new ClienteForm());
        }

        protected override void Reload(object sender, EventArgs e)
        {
            elements.Clear();

            var displays = ClientesRepository.FindAll()
                .Where(cliente => cliente.Nome.ToLower().Contains(elements.FilterText.ToLower()))
                .Select(cliente => new ClienteDisplay(cliente))
                .ToArray();

            foreach (var display in displays)
            {
                display.DetailsButtonClick += (cliente) =>
                    Main.Instance.Clients(new ClienteDetails(cliente));
                display.EditButtonClick += (cliente) =>
                    Main.Instance.Clients(new ClienteForm(cliente));
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
