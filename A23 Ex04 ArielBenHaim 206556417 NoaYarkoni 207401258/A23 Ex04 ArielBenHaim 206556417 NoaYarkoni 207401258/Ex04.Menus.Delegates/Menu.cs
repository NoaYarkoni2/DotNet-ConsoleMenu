using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{ 
    public class Menu
    {
        private const int k_SleepTime = 1200;
        private readonly List<MenuItem> r_UserOptions;
        private readonly int r_Level;
        private string m_Title;
        public int Level
        {
            get
            {
                return r_Level;
            }
        }
        public string Title
        {
            get 
            { 
                return m_Title; 
            } 
            set 
            { 
                m_Title = value; 
            }
        }
        public Menu(string i_Title)
        {
            m_Title = i_Title;
            r_UserOptions = new List<MenuItem>();
            r_Level = 0;
            AddOption(new ActionMenuItem("Exit", null));
        }
        public Menu(string i_Title, Menu i_PreviousMenu)
        {
            m_Title = i_Title;
            r_UserOptions = new List<MenuItem>();
            r_Level = i_PreviousMenu.Level + 1;
            AddOption(new NavigationMenuItem("Back", i_PreviousMenu));
        }
        public void RunMenu()
        {
            while (true)
            {
                showOptions();
                try
                {
                    int userSelection = getInput();
                    Console.Clear();
                    if (userSelection == 0)
                    {
                        break;
                    }

                    r_UserOptions[userSelection].Selected();
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("Error with the input format.{0}{1}", Environment.NewLine, formatException.Message);
                    clearAfterError();
                }
                catch (ValueOutOfRangeException outOfRangeException)
                {
                    Console.WriteLine("Input was out of range.{0}{1}", Environment.NewLine, outOfRangeException.Message);
                    clearAfterError();
                }
            }
        }
        private void clearAfterError()
        {
            Thread.Sleep(k_SleepTime);
            Console.Clear();
        }
        private void showOptions()
        {
            Console.WriteLine("**" + m_Title + "**");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Menu level: " + r_Level);
            int currentOptionToPrint = 1;
            for (int i = 1; i < r_UserOptions.Count; i++)
            {
                Console.WriteLine("{0} -> {1}", currentOptionToPrint, r_UserOptions[i]);
                currentOptionToPrint++;
            }
            Console.WriteLine("0 -> {0}", r_UserOptions[0]);
        }

        private int getInput()
        {
            Console.WriteLine("Enter your request:");
            if (!int.TryParse(Console.ReadLine(), out int userOptionSelection))
            {
                throw new FormatException("You must enter a non negative round number for the selection of the requested option.");
            }
            if (userOptionSelection < 0 || userOptionSelection > r_UserOptions.Count - 1)
            {
                throw new ValueOutOfRangeException(0, r_UserOptions.Count - 1, "Option Selection");
            }
            return userOptionSelection;
        }
        public void AddOption(MenuItem i_MenuItemToAdd)
        {
            r_UserOptions.Add(i_MenuItemToAdd);
        }
    }
}
