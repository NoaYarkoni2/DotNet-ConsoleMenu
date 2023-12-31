﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{

    public class NavigationMenuItem : MenuItem
    {
        private readonly Menu r_LinkedMenu;
        public NavigationMenuItem(string i_Text, Menu i_MenuToNavigateTo) : base(i_Text)
        {
            r_LinkedMenu = i_MenuToNavigateTo;
        }
        protected override void OnSelection()
        {
            r_LinkedMenu.RunMenu();
        }
    }
}
