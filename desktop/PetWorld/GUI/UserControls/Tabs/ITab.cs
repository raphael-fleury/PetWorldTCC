using PetWorld.GUI.UserControls.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetWorld.GUI.UserControls.Tabs
{
    public interface ITab
    {
        void Goto(TabScreen screen);
        void Return();
    }
}
