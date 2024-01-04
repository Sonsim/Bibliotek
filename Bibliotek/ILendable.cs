
namespace Bibliotek
{
    internal interface ILendable
    {

       void lendout(List<Book> library, List<Book> user, Book title);
       void returnbook(List<Book> library, List<Book> user, Book title);

    }
}
