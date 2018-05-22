using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class Action : Option
    {
        private IClickable m_Clickable;
        public IClickable Clickable
        {
            get;set;
        }
        public Action()
        {
            m_Clickable = null;
        }
        internal override void Selected()
        {
            if(Clickable == null)
            {
                Console.WriteLine("Action is not implemented yet!");
            }
            else
            {
                Clickable.Clicked();
            }
        }
    }
}
