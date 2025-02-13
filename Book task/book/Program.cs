namespace book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book("1984", "Джордж Оруел", 1949));
            library.AddBook(new Book("Престъпление и наказание", "Фьодор Достоевски", 1866));
            library.AddBook(new Book("1984", "Джордж Оруел", 1949));

            library.ShowBooks();

            Console.WriteLine(library.FindBookByTitle("1984"));
            Console.WriteLine(library.FindBookByTitle("Няма такава книга"));
        }
    }
}
