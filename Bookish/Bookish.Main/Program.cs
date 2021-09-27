using System;
using Bookish.Net;

namespace Bookish.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BookRepository boooooook = new BookRepository();
            foreach (var book in boooooook.GetAllBooks())
            { 
                Console.WriteLine(book.Book_Name);
            }

            Console.ReadLine();
        }
    }
}
