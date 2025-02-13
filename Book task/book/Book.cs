using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    public class Book : IComparable<Book>
    {
        private string title;
        private string author;
        private int year;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }                
        public int Year { get => year; set => year = value; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;                                     
            Year = year;
        }

        public string GetInfo()
        { 
            return $"{Title} - {Author} ({Year})";                
        }

        //public override bool Equals(object obj)
        //{
        //    if (obj is Book other)
        //    {
        //        return Title.Equals(other.Title, StringComparison.OrdinalIgnoreCase) &&     
        //               Author.Equals(other.Author, StringComparison.OrdinalIgnoreCase);
        //    }
        //    return false;
        //}
        public int CompareTo(Book? other)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return Title.ToLower().GetHashCode() ^ Author.ToLower().GetHashCode();       
        }

        
    }

    class Library : IEnumerable<Book>
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            if (!books.Contains(book))                                              
            {
                books.Add(book);
                Console.WriteLine($"Книгата \"{book.Title}\" е добавена.");
            }
            else
            {
                Console.WriteLine($"Книгата \"{book.Title}\" вече съществува.");
            }
        }

        public void ShowBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Библиотеката е празна.");         
            }
            else
            {
                Console.WriteLine("Списък с книги:");
                foreach (var book in books)
                {
                    Console.WriteLine(book.GetInfo());
                }
            }
        }

        public string FindBookByTitle(string title)
        {
            var foundBook = books.FirstOrDefault(b => b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0);
            return foundBook != null ? foundBook.GetInfo() : "Няма такава книга.";
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
