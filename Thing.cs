using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 物体
    /// </summary>
    class Thing
    {
        readonly public string name;
        public float width;
        public float height;
        public float depth;
        public float weight;
        public float box;
        public Thing(string n = null,float w = 0,float h =0,float d=0 ,float wei = 0)
        {
            name = n;
            width = w;
            height = h;
            depth = d;
            weight = wei;
            box = w + h + d;
        }
    }
}
