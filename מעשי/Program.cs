using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_01._07._20
{
    class Program
    {

        static void PrintAppleColor(Apple p)
        {
            Console.WriteLine(p._color);
        }
        static void PrintBananaSize(Banana b)
        {
            Console.WriteLine(b._size);
        }
        static void PrintFruitSaladCalories(FruitSalad f)
        {
            Console.WriteLine(f.GetTotalCalories()); 
        }
        static void IsTheSaladContainsMyFavorite(FruitSalad f1)
        {
            Console.WriteLine(f1.ContainsMyFavorite()); 
        }
        static void Main(string[] args)
        {

            Apple a = new Apple()
            {
                _calories = 40,
                _color = "Red",
                _name = "Apple 1",
                _pinkLady = false

            };

            Banana b = new Banana()
            {
                _name = "Banana 1",
                _calories = 85,
                _hasBlackSpots = false,
                _isGreen = false,
                _size = 12.5f

            };

            Strewberry s = new Strewberry()
            {
                _name = "Strewberry 1",
                _calories = 150,
                _isRotten = false,
                _weight = 32.1f
            };

            Mango m = new Mango()
            {
                _weight= 47.7f,
                _calories = 220, 
                _hasFewColors= true,
                _name = "Mango 1",
                _size= 15.4f
            };

            FruitSalad one = new FruitSalad()
            {
                _fruits = new Fruit[] { m, s, a }
            };

            PrintAppleColor(a);

            PrintBananaSize(b);
            
            PrintFruitSaladCalories(one);
            
            IsTheSaladContainsMyFavorite(one);

        
        }
    }
}
