using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ActionOption : Option
    {
        public IClickable Clickable
        {
            get; set;
        }
        public ActionOption(String i_Title)
        {
            m_Title = i_Title;
            
        }
        public ActionOption(String i_Title, IClickable i_Clickable)
        {
            m_Title = i_Title;
            Clickable = i_Clickable;

        }

        internal override void Selected()
        {
            if(Clickable != null)
            { 
                Clickable.Click();
                Console.Clear();
            }
        }
    }
}
