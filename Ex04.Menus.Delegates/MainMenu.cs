using System;
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
            /*set? maybe it is read only this guy? 
             * anyway we dont need to set it because the list in Menu class is accesible, it is enough to recive it by ref..
             * i think it can be read only thoughts?*/
        }

        public MainMenu()
        {
            m_MainMenuOptions = new Menu();
            //need to initialize with exit option as 0?
        }
        public void Add(Option i_Option)
        {
            m_MainMenuOptions.Add(i_Option);

        }
        public void DisplayMainMenu()
        {
            Menu.Selected();//also taken care of the case where there is nothing to show here ;)
        }


    }
}

