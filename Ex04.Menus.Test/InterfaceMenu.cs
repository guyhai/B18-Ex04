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
            returnMenu.Menu.m_Title = "Main Menu";
            returnMenu.Add(new Menu("Show Date/Time"));
            List<Option> subMenu = returnMenu.Menu.OptionList;
            (subMenu[1] as Menu).Add(new ActionOption("Show Time", new ShowTime()));
            (subMenu[1] as Menu).Add(new ActionOption("Show Date", new ShowDate()));


            return returnMenu;
        }
    }
}
