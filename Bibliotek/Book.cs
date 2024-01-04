
namespace Bibliotek
{
    internal class Book : ILendable
    {
        private string _title;
        private string _author;
        private string _ISBN;
        private int _prodyear;

        public Book(string title, string author, int prodyear)
        {
            _title = title;
            _author = author;
            _ISBN = new Guid().ToString();
            _prodyear = prodyear;
        }

        public string getguid()
        {
            return _ISBN;
        }

        public string getTitle()
        {
            return _title;
        }

        public string getAuthor()
        {
            return _author;
        }

        public int getprodyear()
        {
            return _prodyear;
        }


        public void lendout(List<Book> library, List<Book> user, Book title)
        {

            if (library.Contains(title))
            {
                library.Remove(title);
                user.Add(title);
            }

        }

        public void returnbook(List<Book> library, List<Book> user, Book title)
        {

            if (user.Contains(title))
            {
                user.Remove(title);
                library.Add(title);
            }

        }
    }
}
