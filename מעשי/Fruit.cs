using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_01._07._20
{
    public abstract class Fruit
    {

        public string _name;
        public int _calories;

        public abstract bool IsThisMyFavorite();

        public override string ToString()
        {
            return $"{base.ToString()} Name : {_name} Calories: {_calories}";
        }
    }
}
