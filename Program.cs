using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("GoT", "George", 1200, "good");
            Book book2 = new Book("LOTR", "Tolkien", 1200, "bad");
            Book book3 = new Book("Lalka", "Mickiewicz", 1200, "asd");

            Console.WriteLine(book1.Rating);
            Console.WriteLine(book2.Rating);
            Console.WriteLine(book3.Rating);
            Console.ReadLine();
        }
    }
}
