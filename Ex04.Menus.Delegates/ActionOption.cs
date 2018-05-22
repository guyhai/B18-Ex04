using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class ActionOption : Option
    {
        public delegate void Click();
        public event Click DoClick;
        public ActionOption(String i_Title)
        {
            m_Title = i_Title;
            
        }
        public ActionOption(String i_Title, Click i_Click)
        {
            m_Title = i_Title;
            DoClick += i_Click;
        }



        internal override void Selected()
        {
            if (DoClick != null)
            {
                
                DoClick.Invoke();
                Console.Clear();

            }
        }
    }
}
