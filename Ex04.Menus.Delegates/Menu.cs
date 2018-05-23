using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
   public class Menu : MenuItem
    {
        private List<MenuItem> m_OptionsList = new List<MenuItem>();
        private const int k_Back = 0;

        public List<MenuItem> OptionList
        {
            get { return m_OptionsList; }
        }


        public Menu()
        {
        }

        public Menu(String i_Title)
        {
            Title = i_Title;
        }

        public Menu(String i_Title, MenuItem iMenuItem)
        {
            Title = i_Title;
            Add(iMenuItem);
        }


        public Menu Add(MenuItem iMenuItem)
        {
            if (m_OptionsList.Count == 0)
            {
                MenuItem back = new ActionMenuItem("Back");
                back.Identifier = 0;
                m_OptionsList.Add(back);
            }

            iMenuItem.Identifier = m_OptionsList.Count;     //Trivial part you give it serial number starting from 1 and then add it to the list :)
            m_OptionsList.Add(iMenuItem);
            return this;
        }

        internal override void Selected()
        {

            if (m_OptionsList.Count != 0)
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
                input = readOption();
                Console.Clear();//clearing console as requested
                if (input != k_Back)
                {
                    m_OptionsList[input].Selected();
                }

            }
        }

        private void printUnderLineOf(string toMultiply)
        {
            string toPrint = "";
            for (int i = 0; i < Title.Length; i++)
            {
                toPrint += toMultiply;
            }

            Console.WriteLine(toPrint);
        }

        private int readOption()
        {
            //read integer from the user 
            int input;
            String str;
            Console.Write($"Choose an MenuItem (number) between [{0},{m_OptionsList.Count-1}]: ");
            str = Console.ReadLine();

            while (!(int.TryParse(str, out input)) || !inRange(0, m_OptionsList.Count, input))
            {
                Console.WriteLine("invalid choice, try again:");
                str = Console.ReadLine();
            }
            return input;
        }

        private void printOptions()
        {
            //maybe need some more work....
            foreach (MenuItem option in m_OptionsList)
            {
                Console.WriteLine($"{option.Identifier}. {option.m_Title}");
                
            }
        }

        private bool inRange(int i_Min, int i_Max, int i_ToCheck)
        {
            return i_ToCheck >= i_Min && i_ToCheck <= i_Max;
        }
    }

}

