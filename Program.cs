using Book;
using System.Xml.Linq;

namespace Book
{
    class Program
    {
        static void Main()
        {
            // Constructor parameters match, allowing object initializer with init-only properties.
            //Book book = new Book("Clean Code", "Robert C. Martin", 2008, "New")
            //{
            //    Title = "C#"
            //};

            // Constructor not match the required parameters so can't use object initializer
            //Book book = new Book("C++")
            //{
            //    Author = "Allison Epstein",
            //    YearPublished = 2025,
            //    Condition = "Good"
            //};

            //Book book = new Book("1984", "George Orwell", 1949, "New");
            //Book book = new Book("++", "Frank Herbert & Co.", 1777, "damaged");
            //Book book = new Book("Les Misérables", "Frank Herbert & Co.", 1965, "GOOD");
            //Book book = new Book("", "Frank Herbert & Co.", 1965, "New");
            //Book book = new Book(null, "Victor Hugo-DuPont", 1965, "");
            Book book = new Book("", "Author! 2023", 1965, " ");

            Console.WriteLine($"\n{"",3}{"Book Title",-17} {"Author",-16} {"Published Year",-17} {"Condition",-15}");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{"",3}{book.Title,-17} {book.Author,-20} {book.YearPublished,-13} {book.Condition}\n");

            //Incorrect changes
            //book.Title = "Clean Code";
            //book.Author = "George Orwell";
            //book.YearPublished = 1949;

            // After checkout, the book is returned and condition changed
            //book.CheckOut();
            //book.ReturnBook();
            //book.Condition = "Good";

            //book.CheckOut();
            //book.ReturnBook();

            book.CheckOut();
            book.CheckOut();

            book.ReturnBook();
            book.ReturnBook();

        }
    }
}