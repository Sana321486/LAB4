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
            Book[] books = new Book[20];
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\tEnter Details for 20 Books");
            Console.WriteLine("--------------------------------------------");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Enter Details for Book {i}");
                books[i] = new Book();
                books[i].Inputbook();
            }
            Console.WriteLine("All Books");
            for (int i = 1; i <= 20; i++)
            {
                books[i].Printbook();
            }
            Console.WriteLine("Enter a book title to search");
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
                    Console.WriteLine("BOOK FOUND");
                    book.Printbook();
                    found = true;
                    break;
                }
                if (!found)
                {
                    Console.WriteLine("Book Not Found");
                }
            }
        }
    } 
}




