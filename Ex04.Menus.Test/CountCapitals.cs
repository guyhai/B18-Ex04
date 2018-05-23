using System;
using System.Text.RegularExpressions;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCapitals : IClickable
    {
        public void Click()
        {
            string line = Console.ReadLine();
            Console.WriteLine($"There are {CapitalsAmount(line)} capital letters");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        public static int CapitalsAmount(string i_Str)
        {
            Regex regex = new Regex("[A-Z]");
            return regex.Matches(i_Str).Count;
        }
    }
}