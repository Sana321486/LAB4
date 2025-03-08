using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MealCard card = new MealCard("Sana");
            card.DisplayBalance();
            card.buyFood(30);
            Console.WriteLine("\n");
            card.DisplayBalance();
            card.buyFood(80);
            card.PurchasePoints(50);
            Console.WriteLine("\n");
            card.DisplayBalance();
            card.buyFood(60);
            card.DisplayBalance();


        }
    }
}
