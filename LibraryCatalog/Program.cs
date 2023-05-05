namespace LibraryCatalog
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Crime and Punishment", "Fyodor Dostoyevsky", 8742542, true);
            Book bookTwo = new Book("Brothers Karamazov", "Fyodor Dostoyevsky", 9242974, false);
            Book bookThree = new Book("Animal Farm", "George Orwell", 724242, true);
            Book bookFour = new Book("1984", "George Orwell", 095446, false);
            Book bookFive = new Book("Rich dad Poor dad", "Robert Kiyosaki", 892589, true);
            Book bookSix = new Book("The Death of Ivan Iliych", "Leo Tolstoy", 246091, false);
            Book bookSeven = new Book("The Idiots", "Fyodor Dostoyevsky", 73842, true);
            Book bookEight = new Book("Master and Magarita", "Mikhail Bulgakov", 96248, false);
 
            Catalog catalog = new Catalog();
            catalog.AddBook(bookOne);
            catalog.AddBook(bookTwo);
            catalog.AddBook(bookThree);  
            catalog.AddBook(bookFour);
            catalog.AddBook(bookFive);
            catalog.AddBook(bookSix);
            catalog.AddBook(bookSeven);
            catalog.AddBook(bookEight);

            User userOne = new User
            {
                Name = "James Stuart",
                Email = "JamesStaurty247@gmail.com"
            };

            User userTwo = new User
            {
                Name = "John Doe",
                Email = "JohnnyDoe26@yahoo.com"
            };

            userOne.CheckOutBook(bookTwo);

            foreach (var book in catalog.GetAvailableBooks())
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}