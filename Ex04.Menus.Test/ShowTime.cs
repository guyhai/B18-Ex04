﻿using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class ShowTime : IClickable
    {
        public void Clicked()
        {
            Console.WriteLine(DateTime.Now.TimeOfDay.ToString());
        }
    }
}
