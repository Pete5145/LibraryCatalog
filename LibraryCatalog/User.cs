using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    public class User
    {  
        private IList<Book> checkedOutBooks = new List<Book>();
        public string Name { get; set; }
        public string Email { get; set; }
        public void CheckOutBook(Book book)
        {
            if (book.CheckedOut == false)
            {
                checkedOutBooks.Add(book);
                book.CheckedOut = true;
            }
            else
                Console.WriteLine($"{book.Title} is already checked out!");
        }
    }
}
