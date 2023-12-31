using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly Menu r_MainScreen;
        public Menu MainScreen
        {
            get
            {
                return r_MainScreen;
            }
        }
        public MainMenu(string i_Title)
        {
            r_MainScreen = new Menu(i_Title);
        }
        public void Show()
        {
            r_MainScreen.RunMenu();
        }
    }
}
