using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    public class Catalog
    { 
       public IList<Book> books { get; set; }
       public void AddBook(Book book)
       {
            books.Add(book);
       }

       public void RemoveBook(Book book)
       {
            books.Remove(book);
       }

       public IList<Book> GetAvailableBooks()
       {
            IList<Book> availableBooks = new List<Book>();

            foreach (var book in books)
            {
                if (book.CheckedOut == false) 
                {
                    availableBooks.Add(book);
                }
            }
            return availableBooks;
        }
       public IList<Book> GetCheckedOutBooks()
       {
            IList<Book> checkedOutBooks = new List<Book>();
            foreach (var book in books) 
            {
                if (book.CheckedOut)
                {
                    checkedOutBooks.Add(book);
                }
            }
            return checkedOutBooks;
        }


    }
}
