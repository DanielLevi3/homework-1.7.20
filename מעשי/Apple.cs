using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_01._07._20
{
    public class Apple : Fruit
    {
        public string _color;
        public bool _pinkLady;

        public override bool IsThisMyFavorite()
        {
            return true;
        }
        public override string ToString()
        {
            return base.ToString() + $" Color : {_color} , PinkLady : {_pinkLady}";
        }
    }
}
