using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinFormsApp1.Users;

namespace WinFormsApp1
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Telefon { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateReg { get; }
        public string Status { get; set; }
        public List<Book> BooksReading { get; set; } // Список книг, которые пользователь читает

        public User(string name, string surname, string address, string telefon, string login, string password)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Telefon = telefon;
            Login = login;
            Password = password;
            DateReg = DateTime.Now;
            Status = "user";
            BooksReading = new List<Book>();
        }

        public override string ToString()
        {
            return $"{Name} : {Surname} : {Address} : {Telefon}";
        }

        public void ReadBook(Book book)
        {
            BooksReading.Add(book);
        }

        public void ReturnBook(Book book)
        {
            BooksReading.Remove(book);
        }
    }
    public class Users
    {
        public static List<User> users = new List<User>();

        // Добавление пользователя
        public static void AddUser(User user)
        {
            users.Add(user);
        }

        // Проверка логина и пароля
        public static User CheckLogin(string username, string password)
        {
            // Ищем пользователя в списке
            User matchingUser = users.FirstOrDefault(user => user.Login == username && user.Password == password);

            return matchingUser; // Возвращает объект User, если пользователь с таким логином и паролем найден, или null, если не найден
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }
            public string Genre { get; set; }
            public string ISBN { get; set; }

            public Book(string title, string author, int year, string genre, string isbn)
            {
                Title = title;
                Author = author;
                Year = year;
                Genre = genre;
                ISBN = isbn;
            }
        }

        public class Library
        {
            public static List<Book> books = new List<Book>();

            public static void AddBook(Book book)
            {
                books.Add(book);
            }

            public static void RemoveBook(Book book)
            {
                books.Remove(book);
            }

            public static List<Book> SearchBooksByTitle(string title)
            {
                return books.Where(book => book.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            public static List<Book> SearchBooksByAuthor(string author)
            {
                return books.Where(book => book.Author.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            public static List<Book> SearchBooksByGenre(string genre)
            {
                return books.Where(book => book.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase)).ToList();
            }
        }
    }
}
