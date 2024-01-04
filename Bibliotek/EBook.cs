

namespace Bibliotek
{
    internal class EBook : Book
    {
        private double _fileSizeInMb;

        public EBook(double filesize, string title, string author, int prodyear) : base(title, author, prodyear)
        {
            _fileSizeInMb = filesize;
        }

        
    }
}
