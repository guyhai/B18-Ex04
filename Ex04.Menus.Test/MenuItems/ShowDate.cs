using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class ShowDate : IClickable
    {
        public void Click()
        {
            Console.WriteLine("The Current Date:");
            Console.WriteLine(DateTime.Now.Date.ToString());
            Console.ReadLine();
        }
    }
}
