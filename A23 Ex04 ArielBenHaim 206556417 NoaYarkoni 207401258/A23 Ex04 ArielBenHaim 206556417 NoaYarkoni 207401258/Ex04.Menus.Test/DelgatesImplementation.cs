using Ex04.Menus.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class DelgatesImplementation
    {
        private MainMenu m_MainMenu;
        public MainMenu BuildMenu()
        {
            m_MainMenu = new MainMenu("Delegates Main Menu");
            Menu mainScreen = m_MainMenu.MainScreen;
            Menu versionAndUppercase = new Menu("Version and Uppercase", mainScreen);
            versionAndUppercase.AddOption(new ActionMenuItem("Show Version", DelegatesTest.ShowVersion));
            versionAndUppercase.AddOption(new ActionMenuItem("Count Uppercase", DelegatesTest.CountUppercase));

            Menu dateAndTime = new Menu("Show Date/Time", mainScreen);
            dateAndTime.AddOption(new ActionMenuItem("Show Date", DelegatesTest.ShowDate));
            dateAndTime.AddOption(new ActionMenuItem("Show Time", DelegatesTest.ShowTime));
            
            mainScreen.AddOption(new NavigationMenuItem("Version and Uppercase", versionAndUppercase));
            mainScreen.AddOption(new NavigationMenuItem("Show Date/Time", dateAndTime));
            return m_MainMenu;
        }
        public void RunMenu()
        {
            BuildMenu();
            m_MainMenu.Show();
        }

    }
}
