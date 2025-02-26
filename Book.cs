
namespace Book
{
    internal class Book
    {
        private string? title;
        private string? author;
        private int yearPublished;
        private bool isAvailable;
        private string? condition;

        public Book(string title, string author, int yearPublished, string condition) =>
            (Title, Author, YearPublished, Condition, IsAvailable) =
            (title, author, yearPublished, condition, true);

        public string? Title
        {
            get => title;
            init
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Any(c => char.IsLetterOrDigit(c)))
                {
                    title = value;
                    return;
                }
                title = "Invalid Title";
            }
        }
        public string? Author
        {
            get => author;
            init
            {
                if (!string.IsNullOrWhiteSpace(value) && !value.All(c => char.IsDigit(c)) &&
                     value.Any(c => char.IsLetter(c)))
                {
                    author = value;
                    return;
                }
                author = "Invalid Author Name";
            }
        }
        public int YearPublished
        {
            get => yearPublished;
            init => yearPublished = value >= 1900 ? value : 1900;
        }
        public bool IsAvailable { get => isAvailable; private set => isAvailable = value; }

        public string? Condition
        {
            get => condition;
            set
            {
                var bookConditions = new[] { "New", "Good", "Worn", "Damaged" };
                if (!string.IsNullOrWhiteSpace(value) &&
                    bookConditions.Any(c => value.Equals(c, StringComparison.OrdinalIgnoreCase)))
                {
                    condition = value;
                    return;
                }
                condition = "Unknown";
            }
        }

        public void CheckOut()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine("Book checked out successfully.");
            }
            else
            {
                Console.WriteLine("Book is already checked out.");
            }
        }
        public void ReturnBook()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine("Book returned successfully.");
            }
            else
            {
                Console.WriteLine("Book is already available.");
            }
        }
    }
}