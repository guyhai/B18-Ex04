using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ActionMenuItem : MenuItem
    {
        public IClickable Clickable
        {
            get; set;
        }
        public ActionMenuItem(String i_Title)
        {
            Title = i_Title;
            
        }
        public ActionMenuItem(String i_Title, IClickable iClickable)
        {
            Title = i_Title;
            Clickable = iClickable;

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
