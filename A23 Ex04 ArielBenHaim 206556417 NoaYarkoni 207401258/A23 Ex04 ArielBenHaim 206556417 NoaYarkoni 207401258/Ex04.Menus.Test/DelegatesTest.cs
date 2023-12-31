using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class DelegatesTest
    {
        public static void ShowVersion()
        {
            Console.WriteLine("Version: 23.1.4.8859");
        }
        public static void CountUppercase()
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
        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt"));
        }
        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
        }
    }
}
