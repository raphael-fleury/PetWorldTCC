using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetWorld.GUI.Forms;
using PetWorld.Data.Entities;
using PetWorld.Data.Entities.Enums;
using PetWorld.Data.Repositories;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class PetsForm : Tab
    {
        private Tab callback;

        public PetsForm(Tab callback)
        {
            InitializeComponent();
            this.callback = callback;
        }

        private void Return(object sender, EventArgs e)
        {
            Main.LoadScreen(callback ?? new Pets());
        }

        private void Done(object sender, EventArgs e)
        {
            Sexo sexo = rbMasculino.Checked ? Sexo.MASCULINO : Sexo.FEMININO;
            Pet pet = new Pet(txtNome.Text, txtEspecie.Text, txtRaca.Text, cbCastrado.Checked, sexo, null);
            PetsRepository.Save(pet);
            
            Return(sender, e);
        }
    }
}
