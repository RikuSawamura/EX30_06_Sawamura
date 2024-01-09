using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// ヒト
    /// </summary>
    class Person : Animal
    {
        readonly string gender;
        public Person(string gender,DateTime bd, string n, float w = 0, float h = 0, float d = 0, float wei = 0, float life = 0) : base(bd, n, w, h, d, wei, life)
        {
            this.gender = gender;
        }
    }
}
