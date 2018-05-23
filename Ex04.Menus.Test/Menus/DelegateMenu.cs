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
            List<MenuItem> subMenu = returnMenu.Menu.OptionList;

            //Note that though all options implement the clickable iterface, it's not necessary here
            //as we send a pointer to the click function, which can be any other function - user preference.

            (subMenu[1] as Menu).Add(new ActionMenuItem("Show Time", new ShowTime().Click));
            (subMenu[1] as Menu).Add(new ActionMenuItem("Show Date", new ShowDate().Click));

            returnMenu.Add(new Menu("Version and Capitals"));
            subMenu = returnMenu.Menu.OptionList;
            (subMenu[2] as Menu).Add(new ActionMenuItem("Count Capitals", new CountCapitals().Click));
            (subMenu[2] as Menu).Add(new ActionMenuItem("Show Version", new ShowVersion().Click));


            return returnMenu;
        }
    }
}
