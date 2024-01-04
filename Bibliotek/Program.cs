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

            SelectBooK(library);
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

        private static Book SelectBooK(List<ILendable> library)
        {
            Console.WriteLine("Which book do you want to select?");
            int i = 1;
            foreach (Book book in library)
            {
                
                Console.WriteLine($"{i}. {book.getTitle()}");
                i++;
            }

            var ans = Console.ReadLine();

            foreach (Book book in library)
            {
                if (ans.ToLower() == book.getTitle())
                {
                    {
                        return book;
                        
                    }
                }
            }

            return null;
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


