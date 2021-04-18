using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PetWorld.GUI.UserControls.Components;
using PetWorld.GUI.Forms;
using PetWorld.Data.Repositories;
using PetWorld.GUI.UserControls.Tabs;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class Pets : TabScreen
    {
        public Pets()
        {
            InitializeComponent();
            elements.FilterTextChanged += () => Reload(this, EventArgs.Empty);
        }

        private void Add(object sender, EventArgs e)
        {
            Main.Instance.Pets(new PetsForm());
        }

        protected override void Reload(object sender, EventArgs e)
        {
            elements.Clear();

            var displays = PetsRepository.FindAll()
                .Where(pet => pet.Nome.ToLower().Contains(elements.FilterText.ToLower()))
                .Select(pet => new PetDisplay(pet))
                .ToArray();

            foreach (var display in displays)
            {
                display.DetailsButtonClick += (pet) =>
                    Main.Instance.Pets(new PetDetails(pet));
                display.EditButtonClick += (pet) =>
                    Main.Instance.Pets(new PetsForm(pet));
                display.DeleteButtonClick += (pet) =>
                {
                    var result = MessageBox.Show("Deseja deletar " + pet.Nome + "?", "Deletar Pet", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                        PetsRepository.DeleteById(pet.Id.Value);
                    Reload(this, EventArgs.Empty);
                };
            }
            
            elements.Add(displays.ToArray());
        }
    }
}
