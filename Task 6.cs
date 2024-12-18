using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Book
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }

    public Book(string name, string publisher, string year, string genre)
        {
            Name = name;
            Publisher = publisher;
            Year = year;
            Genre = genre;
        }

    public void displayInformation()
        {
            Console.WriteLine($"Name: {Name}, Publisher: {Publisher}, Year {Year}, Genre {Genre}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("To Kill a Mockingbird", "Harper Lee", "1960", "Fiction");
            Book book2 = new Book("Denna bok har ingen tittel", "Författare", "1923", "Komedi");

            book.displayInformation();
            book2.displayInformation();
        }
    }
}
