using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_01._07._20
{
    public class Banana : Fruit
    {
        public bool _hasBlackSpots;
        public bool _isGreen;
        public float _size;

        public override bool IsThisMyFavorite()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $"HasBlackSpots : {_hasBlackSpots} , IsGreen : {_isGreen} ,Size : {_size} ";
        }
    }
}
