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
        public static void Start()
        {
            MainMenu main = create();
            main.DisplayMainMenu();
        }

        private static MainMenu create()
        {
            MainMenu returnMenu = new MainMenu();
            returnMenu.Menu.Title = "Main Menu";

            returnMenu.Add(new Menu("Show Date/Time"));
            List<MenuItem> subMenu = returnMenu.Menu.MenuItems;
            (subMenu[1] as Menu).Add(new ActionMenuItem("Show Time", new ShowTime()));
            (subMenu[1] as Menu).Add(new ActionMenuItem("Show Date", new ShowDate()));

            returnMenu.Add(new Menu("Version and Capitals"));
            subMenu = returnMenu.Menu.MenuItems;
            (subMenu[2] as Menu).Add(new ActionMenuItem("Count Capitals", new CountCapitals()));
            (subMenu[2] as Menu).Add(new ActionMenuItem("Show Version", new ShowVersion()));

            return returnMenu;
        }
    }

 }
