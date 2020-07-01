using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_01._07._20
{
    class Strewberry : Fruit
    {
        public bool _isRotten;
        public float _weight;

        public override bool IsThisMyFavorite()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $"IsRotten : {_isRotten} , Weight : {_weight}";
        }
    }
}
