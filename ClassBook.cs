using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

    namespace WinFormsApp1
    {
        public class Library
        {
            public List<Book> Books { get; set; }

            public Library()
            {
                // Инициализация коллекции книг
                Books = new List<Book>();
            }

            // Добавление новой книги
            public void AddBook(Book book)
            {
                Books.Add(book);
            }

            // Методы для поиска книг
            public List<Book> SearchByTitle(string title)
            {
                return Books.Where(book => book.Title.Contains(title)).ToList();
            }

            public List<Book> SearchByAuthor(string author)
            {
                return Books.Where(book => book.Author.Contains(author)).ToList();
            }

            public List<Book> SearchByGenre(string genre)
            {
                return Books.Where(book => book.Genre.Contains(genre)).ToList();
            }

            public List<Book> SearchByISBN(string isbn)
            {
                return Books.Where(book => book.ISBN.Contains(isbn)).ToList();
            }

            // Другие методы для управления книгами, например, удаление и т.д.
        }


        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }
            public string Genre { get; set; }
            public string ISBN { get; set; }

            public override string ToString()
            {
                return $"{Title} by {Author}, {Year}, Genre: {Genre}, ISBN: {ISBN}";
            }
        }
    }
