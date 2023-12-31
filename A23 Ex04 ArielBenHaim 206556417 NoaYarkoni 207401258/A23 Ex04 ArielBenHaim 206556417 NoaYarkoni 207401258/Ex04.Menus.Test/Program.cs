using Ex04.Menus.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            DelgatesImplementation delegatesRunner = new DelgatesImplementation();
            InterfacesImplementation interfacesRunner = new InterfacesImplementation();
            interfacesRunner.RunMenu();
            SwitchMenusScreen();
            delegatesRunner.RunMenu();
        }

        public static void SwitchMenusScreen()
        {
            Console.WriteLine("Switching to the delegates-implemented menu...");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
}
