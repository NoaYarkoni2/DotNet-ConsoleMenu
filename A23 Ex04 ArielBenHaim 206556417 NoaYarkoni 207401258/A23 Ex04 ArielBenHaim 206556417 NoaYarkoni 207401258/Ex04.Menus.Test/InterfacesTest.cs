using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfacesTest
    {
        public class ShowVersion : IRunable
        {
            public void Run()
            {
                Console.WriteLine("Version: 23.1.4.8859");
            }
        }
        public class CountUppercase : IRunable
        {
            public void Run()
            {
                Console.Write("Enter a sentence in English: ");
                string sentence = Console.ReadLine();
                int count = 0;
                foreach (char c in sentence)
                {
                    if (char.IsUpper(c))
                    {
                        count++;
                    }
                }
                Console.WriteLine("Number of uppercase letters: " + count);
            }
        }
        public class ShowTime : IRunable
        {
            public void Run()
            {
                Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));
            }
        }
        public class ShowDate : IRunable
        {
            public void Run()
            {
                Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            }
        }
    }
}