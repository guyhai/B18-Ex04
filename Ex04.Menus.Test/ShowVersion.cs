using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IClickable
    {
        public void Click()
        {
            Console.WriteLine("Version: 18.2.4.0");
            Console.ReadLine();
        }
    }
}