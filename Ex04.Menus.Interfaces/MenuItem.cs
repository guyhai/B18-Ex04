using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_Title = "";
        private int m_Identifier = 0;
        internal abstract void Selected();

        internal int Identifier
        {
            get { return m_Identifier; }
            set { m_Identifier = value; }
        }
        public string Title
        {
            get { return m_Title ; }
            set { m_Title = value; }
        }



    }
}
