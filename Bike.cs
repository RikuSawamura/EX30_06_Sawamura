﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30_2023_template
{
    /// <summary>
    /// 自転車
    /// </summary>
    internal class Bike : Vehicle
    {
        public Bike(string n, float w = 0, float h = 0, float d = 0, float wei = 0) : base(n, w, h, d, wei)
        {

        }
    }
}
