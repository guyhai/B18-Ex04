using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    class Action : Option
    {
        public delegate void Click();
        public event Click DoClick;
        public Action(String i_Title, Click i_Click)
        {
            m_Title = i_Title;
            DoClick = i_Click;
        }

        internal override void Selected()
        {
            //didnt understand how to do it!
        }
    }
}
