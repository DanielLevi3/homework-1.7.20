using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_01._07._20
{
    public class Mango : Fruit
    {
        public float _weight;
        public float _size;
        public bool _hasFewColors;

        public override bool IsThisMyFavorite()
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + $"Weight: {_weight}, Size: {_size} ,HasFewColors : {_hasFewColors} ";
        }
    }
}
