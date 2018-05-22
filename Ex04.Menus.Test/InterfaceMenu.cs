using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class InterfaceMenu
    {
        public static void ShowMainMenu()
        {
            MainMenu main = new MainMenu();

            main.Show();
        }
        
    }
}
