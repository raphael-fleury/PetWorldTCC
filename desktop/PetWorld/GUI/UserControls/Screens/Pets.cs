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
        }

        private void Add(object sender, EventArgs e)
        {
            Main.LoadScreen(new PetsForm(this));
        }

        private void Reload(object sender, EventArgs e)
        {
            foreach (Pet pet in PetsRepository.FindAll())
            {
                elements.Add(new PetDisplay(pet));
            }
        }
    }
}
