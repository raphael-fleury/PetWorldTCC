﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetWorld.GUI.UserControls.Components;

namespace PetWorld.GUI.UserControls.Screens
{
    public partial class Pets : Tab
    {
        public Pets()
        {
            InitializeComponent();
            button1.Click += (x, y) => elementsDisplay1.Add(new Pet());
        }
    }
}
