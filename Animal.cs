﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 動物
    /// </summary>
    class Animal : Life
    {
        public Animal(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float wei = 0, float life = 0) : base(bd, n, w, h, d, wei, life)
        {
        }
    }
}
