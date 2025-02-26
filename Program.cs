using Book;

namespace Book
{
    class Program
    {
        static void Main()
        {
            //Book book = new Book("C++")
            //{
            //    Author = "Allison Epstein",
            //    YearPublished = 2025,
            //    Condition = "Good"
            //};
            Book book = new Book("++", "122", 2025, "");
            //{ 
            //    Title ="C++"
            //};
            //Console.WriteLine(book.Condition); what is the default
            //book.Author = "mona";
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);



        }
    }
}