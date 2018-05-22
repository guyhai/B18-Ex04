using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class DelegateMenu
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
            (subMenu[1] as Menu).Add(new ActionOption("Show Time", new ShowTime().Click));
            (subMenu[1] as Menu).Add(new ActionOption("Show Date", new ShowDate().Click));

            
            return returnMenu;
        }
    }
}
