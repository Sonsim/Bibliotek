namespace Bibliotek
{
    internal class Program
    {
        static void Main()
        {
            List<ILendable> user = new();
            List<ILendable> library = new() {
            new Book("1884", "George Orewell", 1970),
            new Book("Blood of Elves", "Andrzej Sapkowski", 2009),
            new Book("Koding for alle i Javascript", "Terje Koldrup", 2023),
        };
            PrintAll(library);
            Console.ReadKey();

            var adding = true;
            while (adding)
            {
                Console.Clear();
                AskToAdd(adding, library);
            }

            PrintAll(library);
            Console.ReadKey();
            

            borrow();

        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do? \n" +
                              "1. Show all books in libray \n" +
                              "2. Add book to library \n" +
                              "3. Loan book \n" +
                              "4. Return book \n" +
                              "5. Export list of books to textfile \n" +
                              "6. Exit program");
            var ans = Console.ReadLine();

            

        } 

        private static void borrow()
        {
            Console.Clear();
            Console.WriteLine("would you like to borrow a book? Y/N ");
            string? answer = null;
            while (string.IsNullOrEmpty(answer)) answer = Console.ReadLine().ToLower();
            if (answer == "n") { }
        }

        private static void AskToAdd(bool adding, List<ILendable> library)
        {
            Console.WriteLine("would you like to add a book? Y/N ");

            string? answer = null;
            while (string.IsNullOrEmpty(answer)) answer = Console.ReadLine().ToLower();

            if (answer == "n")
            {
                adding = false;
                return;
            }
            library.Add(addbook());
        }


        private static Book addbook()
        {
            Console.Clear();
            Console.WriteLine("What is the name of the book?");
            var title = Console.ReadLine();
            Console.WriteLine("What is the name of the author?");
            var author = Console.ReadLine();
            Console.WriteLine("What year was it published?");
            var year = Convert.ToInt32(Console.ReadLine());

            var newbook = new Book(title, author, year);
            return newbook;
        }

        private static void PrintAll(List<ILendable> library)
        {
            foreach (Book book in library)
            {
                Console.WriteLine($"Title         : {book.getTitle()} \n" +
                                  $"GUID          : {book.getguid()}\n" +
                                  $"Author        : {book.getAuthor()} \n" +
                                  $"ProductionYear: {book.getprodyear()}\n\n");

            }
        }
    }
}


