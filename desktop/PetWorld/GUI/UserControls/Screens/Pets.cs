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
    public partial class Pets : Tab
    {
        public Pets()
        {
            InitializeComponent();
            elements.FilterTextChanged += () => Reload(this, EventArgs.Empty);
        }

        private void Add(object sender, EventArgs e)
        {
            Main.LoadScreen(new PetsForm(this));
        }

        public override void Reload(object sender, EventArgs e)
        {
            elements.Clear();

            var displays = PetsRepository.FindAll()
                .Where(pet => pet.Nome.ToLower().Contains(elements.FilterText.ToLower()))
                .Select(pet => new PetDisplay(pet))
                .ToArray();

            foreach (var display in displays)
            {
                display.DetailsButtonClick += (pet) =>
                    Main.LoadScreen(new PetDetails(this, pet));
                display.EditButtonClick += (pet) => 
                    Main.LoadScreen(new PetsForm(this, pet));
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
