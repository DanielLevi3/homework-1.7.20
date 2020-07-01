using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_01._07._20
{
    public class FruitSalad
    {
        public Fruit[] _fruits;

        public int GetTotalCalories()
        {
            int sum = 0;

            for (int i = 0; i < _fruits.Length; i++)
            {
                sum =  sum + _fruits[i]._calories;
            }

            return sum;
        }

        public bool ContainsMyFavorite()
        {
            for (int i = 0; i < _fruits.Length; i++)
            {
                if (_fruits[i].IsThisMyFavorite()) // if (_fruits[i].IsThisMyFavorite() == true)
                    return true; // this JUMPS out of the function and return true!
            }

            // if you are here it means you did not JUMP out because no fruit is your favorite
            return false;
            
        }

        public override string ToString()
        {
            string result = "FruitSalad class. fruits in salad: \n";
            for (int i = 0; i < _fruits.Length; i++)
            {
                result = result + _fruits[i].ToString() + "\n";
            }
            return result;
        }
    }
}
