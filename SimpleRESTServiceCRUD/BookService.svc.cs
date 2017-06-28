using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleRESTServiceCRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookService.svc or BookService.svc.cs at the Solution Explorer and start debugging.
    public class BookService : IBookService
    {

        static IBookRepository repository = new BookRepository();

        public string AddBook(Book book, string id)
        {
            Book newBook = repository.AddNewBook(book);
            return $"id = {newBook.BookId}";
        }

        public string DeleteBook(string id)
        {
            bool deleted = repository.DeleteBook(int.Parse(id));
            if (deleted)
                return "Book with id =" + id + " deleted";
            else
                return "Unable to Delete book with id =" + id;
        }

        public Book GetBookById(string id)
        {
            return repository.GetBookById(int.Parse(id));
        }

        public List<Book> GetBookList()
        {
            return repository.GetAllBooks();
        }

        public string UpdateBook(Book book, string id)
        {
            bool updated = repository.UpdateABook(book);
            if (updated)
                return "Book with id =" + id + " updated";
            else
                return "Unable to updated book with id =" + id;
        }
    }
}
