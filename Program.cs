using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[2];
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\tEnter Details for 2 Books");
            Console.WriteLine("--------------------------------------------");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter Details for Book {i+1}");
                books[i] = new Book();
                books[i].Inputbook();
                Console.WriteLine("\n");
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("\tAll Books");
            Console.WriteLine("------------------------");
            for (int i = 0; i < 2; i++)
            {
                books[i].Printbook();
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\tEnter a book title to search");
            Console.WriteLine("---------------------------------------");
            string searchtitle = Console.ReadLine();
            searchbook (books, searchtitle);
        }
        public static void searchbook(Book[] books, string title)
        {
            bool found = false;
            foreach (Book book in books)
            {
                if (book.title == title)
                {
                    Console.WriteLine("*****BOOK FOUND*****");
                    book.Printbook();
                    found = true;
                    break;
                }
                if (!found)
                {
                    Console.WriteLine("*****Book Not Found*****");
                }
            }
        }
    } 
}




