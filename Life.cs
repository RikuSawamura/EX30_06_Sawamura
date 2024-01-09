using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 生き物
    /// </summary>
    class Life : Thing
    {
        readonly private string _name;
        readonly private DateTime _birthDay = new DateTime();
        public float lifespan;
        public DateTime Birthday
        {
            get { return _birthDay; }
        }
        new public string Name
        {
            get { return _name; }
        }
        public Life(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float wei = 0, float life = 0) : base(n, w, h, d, wei)
        {
            this._name = n;
            this._birthDay = bd;
            this.lifespan = life;
        }
        public int Age()
        {
            return DateTime.Now.Year - this._birthDay.Year;
        }
        public bool BirgthdayJudge()
        {
            if (_birthDay.Month == DateTime.Today.Month && _birthDay.Day == DateTime.Today.Day)
                return true;
            else
                return false;
        }
    }
}
