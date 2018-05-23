using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
   public class Menu : Option
    {
        private List<Option> m_OptionsList;
        private const int k_Back = 0;
       
            public List<Option> OptionList
        {
            get { return m_OptionsList; }
            
        }
        public Menu()
        {
            m_OptionsList = new List<Option>();
            
        }
        public Menu(String i_Title)
        {
            m_OptionsList = new List<Option>();
            Title = i_Title;
        }
        public Menu(String i_Title, Option i_Option)
        {
            m_OptionsList = new List<Option>();
            Title = i_Title;
            Add(i_Option);
        }
        public Menu Add(Option i_Option)
        {
            if (m_OptionsList.Count == 0)
            {
                Option back = new ActionOption("Back");
                back.Identifier = 0;
                m_OptionsList.Add(back);//since it is a loop in a loop no need to inplement back
            }
            i_Option.Identifier = m_OptionsList.Count;// trivial part you give it serial number starting from 1 and then add it to the list :)
            m_OptionsList.Add(i_Option);
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
                Console.WriteLine(Title + "\n");
                printOptions();
                input = readOption();
                Console.Clear();//clearing console as requested
                if (input != k_Back)
                {
                    m_OptionsList[input].Selected();
                }

            }
        }

        private int readOption()
        {
            //read integer from the user 
            int input;
            String str;
            Console.Write($"Choose an Option (number) between [{0},{m_OptionsList.Count-1}]: ");
            str = Console.ReadLine();

            while (!(int.TryParse(str, out input)) || !inRange(0, m_OptionsList.Count - 1, input))
            {
                Console.WriteLine("invalid choice, try again:");
                str = Console.ReadLine();
            }
            return input;
        }

        private void printOptions()
        {
            //maybe need some more work....
            foreach (Option option in m_OptionsList)
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

