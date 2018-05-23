using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class Menu : MenuItem
    {
        private List<MenuItem> m_MenuItems;
        private const int k_Back = 0;

        public List<MenuItem> MenuItems
        {
            get { return m_MenuItems; }
        }

        public Menu()
        {
            m_MenuItems = new List<MenuItem>();
        }
        public Menu(String i_Title)
        {
            m_MenuItems = new List<MenuItem>();
            Title = i_Title;
        }
        public Menu(String i_Title, MenuItem iMenuItem)
        {
            m_MenuItems = new List<MenuItem>();
            Title = i_Title;
            Add(iMenuItem);
        }

        public Menu Add(MenuItem i_MenuItem)
        {
            if (m_MenuItems.Count == 0)
            {
                MenuItem back = new ActionMenuItem("Back");
                back.Identifier = 0;
                m_MenuItems.Add(back);//since it is a loop in a loop no need to inplement back
            }
            i_MenuItem.Identifier = m_MenuItems.Count;// trivial part you give it serial number starting from 1 and then add it to the list :)
            m_MenuItems.Add(i_MenuItem);
            return this;
        }

        internal override void Selected()
        {
            if(m_MenuItems.Count != 0)
            {
                PresentInteractiveMenu();
            }
            else
            {
                Console.WriteLine("nothing to show yet, maybe Add some options?");
            }
        }

        private void PresentInteractiveMenu()
        {
            int input = -1;
            while (input != k_Back)
            {
                Console.WriteLine(Title);
                printUnderLineOf("=");
                Console.WriteLine();

                printOptions();
                Console.WriteLine();
                input = readOption();
                Console.Clear();//clearing console as requested
                if (input != k_Back)
                {
                    m_MenuItems[input].Selected();
                }

            }
        }

        private void printUnderLineOf(string i_ToMultiply)
        {
            string toPrint = "";
            for (int i = 0; i < Title.Length; i++)
            {
                toPrint += i_ToMultiply;
            }

            Console.WriteLine(toPrint);
        }

        private int readOption()
        {
            //read integer from the user 
            int input;
            String str;
            Console.Write($"Choose an action (number between [{0},{m_MenuItems.Count - 1}]): ");
            str = Console.ReadLine();

            while (!(int.TryParse(str, out input)) || !inRange(0, m_MenuItems.Count-1, input))
            {
                Console.WriteLine("invalid choice, try again:");
                str = Console.ReadLine();
            }
            return input;
        }

        private void printOptions()
        {
            //maybe need some more work....
            foreach (MenuItem option in m_MenuItems)
            {
                Console.WriteLine($"{option.Identifier}. {option.Title}");
            }
        }

        private bool inRange(int i_Min, int i_Max, int i_ToCheck)
        {
            return i_ToCheck >= i_Min && i_ToCheck <= i_Max;
        }
    }
}
