using Entities.Concrete;

namespace Business.Abstract;

public interface IBookService
{
     List<Book> GetBookList();

     Book Add(Book book);
     
     Book Delete(Book book);
     
}