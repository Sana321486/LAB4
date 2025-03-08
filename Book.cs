using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Book
    {
        public int ISBN;
        public string title;
        public int price;
        public string majorarea;
        public string subarea;
        public int numofpg;
        public void Inputbook()
        {
            Console.Write($"Enter ISBN:");
            ISBN = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter Title:");
            title = Console.ReadLine();
            Console.Write($"Enter Price:");
            price = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter Major Area:");
            majorarea = Console.ReadLine();
            Console.Write($"Enter Sub Area:");
            subarea = Console.ReadLine();
            Console.Write($"Enter Number of Pages:");
            numofpg = Convert.ToInt32(Console.ReadLine());
        }
        public void Printbook()
        {
            Console.WriteLine($" ISBN:{ISBN}");
            Console.WriteLine($" Title:{title}");
            Console.WriteLine($" Price:{price}");
            Console.WriteLine($" Major Area:{majorarea}");
            Console.WriteLine($" Sub Area:{subarea}");
            Console.WriteLine($" Number of Pages:{numofpg}");

        }
    }
   

   
    
}

