﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class Function
    {
        public string ReturnsPikachuIfZero(int num)
        {
            if (num == 0)
                return "pikachu";
            else
                return "charmander";
        }
    }
}
