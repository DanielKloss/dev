using GenericsExample.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.uniqueId = 123;
            book.numberOfPages = 450;

            Magazine magazine = new Magazine();
            magazine.uniqueId = 534;

            Cd cd = new Cd();
            cd.uniqueId = 987;

            ItemCatalogue<Book> genericBookCatalogue = new ItemCatalogue<Book>();
            genericBookCatalogue.Add(book);
            int numberOfPagesInFirstBook = genericBookCatalogue.GetAllItems().First().numberOfPages;

            Console.WriteLine(numberOfPagesInFirstBook);
            Console.ReadLine();
        }
    }
}
