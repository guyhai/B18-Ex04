﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private Menu m_MainMenuOptions;//maybe there is a better name for it.
        public Menu Menu
        {
            get { return m_MainMenuOptions; }
            
        }

        public MainMenu()
        {
            m_MainMenuOptions = new Menu();
            
        }
        public void Add(MenuItem iMenuItem)
        {
            m_MainMenuOptions.Add(iMenuItem);
            //here i take "back" and change it into "Exit"
            if (m_MainMenuOptions.MenuItems.Count == 2)
          {
              m_MainMenuOptions.MenuItems[0].Title = "Exit";
          }
        }
        public void DisplayMainMenu()
        {
            Menu.Selected();        //also taken care of the case where there is nothing to show here ;)
        }


    }
}

