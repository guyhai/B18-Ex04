using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
            public class MainMenu
    {
        private Menu m_MainMenuOptions;//maybe there is a better name for it.
        public Menu Menu
        {
            get { return m_MainMenuOptions;}
            /*set? maybe it is read only this guy? 
             * anyway we dont need to set it because the list in Menu class is accesible, it is enough to recive it by ref..
             * i think it can be read only thoughts?*/
        }
        public MainMenu()
        {

            m_MainMenuOptions = new Menu();
            m_MainMenuOptions.Title = "Main Menu";

        }
        public void Add(Option i_Option)
        {
            m_MainMenuOptions.Add(i_Option);
            //here i take "back" and change it into "Exit"
            if (m_MainMenuOptions.m_OptionsList.Count == 2)
            {
                m_MainMenuOptions.m_OptionsList[0].Title = "Exit";
            }

        }
         public void DisplayMainMenu()

        {
            m_MainMenuOptions.Selected();//also taken care of the case where there is nothing to show here ;)
        }
    }
}
