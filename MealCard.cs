using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class MealCard
    {
        public string studentname;
        public int balance;
        public MealCard(string studentname, int initialbalance = 100)
        {
            this.studentname = studentname;
            this.balance = initialbalance;
        }
        public void PurchasePoints(int points)
        {
            balance += points;
            Console.WriteLine($"Point added:{points}");
            Console.WriteLine($"New Balance:{balance}");
        }
            public void buyFood(int cost)
        {
            if (balance >= cost)
            {
                balance -= cost;
                Console.WriteLine($"Food purchase for points:{cost}");
                Console.WriteLine($"Remaining balance:{balance}");
            }
            else
            {
                Console.WriteLine("Invalid cost amount");
            }
        }
        public void DisplayBalance()
        {
            Console.WriteLine($"Current Balance points: {balance}");
        }
    }
}
      

