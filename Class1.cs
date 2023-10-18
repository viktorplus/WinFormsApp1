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
        public static List<Book> books = new List<Book>
    {
        new Book("Война и мир", "Лев Толстой", 1869, "Роман", "978-5-699-67510-6"),
        new Book("Мастер и Маргарита", "Михаил Булгаков", 1967, "Роман", "978-5-04-000102-3"),
        new Book("Преступление и наказание", "Федор Достоевский", 1866, "Роман", "978-5-699-64185-2"),
        new Book("Три мушкетера", "Александр Дюма", 1844, "Роман", "978-5-60402350-7"),
        new Book("Процесс", "Франц Кафка", 1925, "Роман", "978-5-17-122264-9"),
        new Book("1984", "Джордж Оруэлл", 1949, "Роман", "978-5-17-032802-3"),
        new Book("Гарри Поттер и философский камень", "Джоан Роулинг", 1997, "Фэнтези", "978-5-04-001387-3"),
        new Book("Гарри Поттер и Тайная комната", "Джоан Роулинг", 1998, "Фэнтези", "978-5-04-001703-1"),
        new Book("Гарри Поттер и узник Азкабана", "Джоан Роулинг", 1999, "Фэнтези", "978-5-04-001704-8"),
        new Book("Гарри Поттер и Кубок огня", "Джоан Роулинг", 2000, "Фэнтези", "978-5-04-001722-2"),
        new Book("Гарри Поттер и орден Феникса", "Джоан Роулинг", 2003, "Фэнтези", "978-5-04-001725-3"),
        new Book("Гарри Поттер и Принц-полукровка", "Джоан Роулинг", 2005, "Фэнтези", "978-5-04-001726-0"),
        new Book("Гарри Поттер и Дары Смерти", "Джоан Роулинг", 2007, "Фэнтези", "978-5-04-001727-7"),
        new Book("Идиот", "Федор Достоевский", 1869, "Роман", "978-5-17-061799-1"),
        new Book("Анна Каренина", "Лев Толстой", 1877, "Роман", "978-5-17-063318-2"),
        new Book("Мёртвые души", "Николай Гоголь", 1842, "Роман", "978-5-9905831-7-6"),
        new Book("Евгений Онегин", "Александр Пушкин", 1833, "Роман в стихах", "978-5-04-028358-3"),
        new Book("Властелин колец: Братство кольца", "Дж.Р.Р. Толкин", 1954, "Фэнтези", "978-5-17-092594-5"),
        new Book("Властелин колец: Две крепости", "Дж.Р.Р. Толкин", 1954, "Фэнтези", "978-5-17-090889-4"),
        new Book("Властелин колец: Возвращение короля", "Дж.Р.Р. Толкин", 1955, "Фэнтези", "978-5-17-095611-7"),
        new Book("Белая гвардия", "Михаил Булгаков", 1924, "Роман", "978-5-17-083801-9"),
        new Book("Мертвые души", "Михаил Булгаков", 1932, "Повесть", "978-5-17-098464-6"),
        new Book("Собачье сердце", "Михаил Булгаков", 1925, "Повесть", "978-5-17-097183-7"),
        new Book("Палата №6", "Антон Чехов", 1892, "Рассказ", "978-5-699-24524-5"),
        new Book("Капитанская дочка", "Александр Пушкин", 1836, "Роман", "978-5-17-084879-7"),
        new Book("Записки из мертвого дома", "Федор Достоевский", 1861, "Рассказ", "978-5-17-101049-5"),
        new Book("Маленький принц", "Антуан де Сент-Экзюпери", 1943, "Сказка", "978-5-17-121220-6"),
        new Book("Унесенные ветром", "Маргарет Митчелл", 1936, "Роман", "978-5-699-57163-0"),
        new Book("Над пропастью во ржи", "Джером Сэлинджер", 1951, "Роман", "978-5-17-108553-0"),
        new Book("Три товарища", "Эрих Мария Ремарк", 1936, "Роман", "978-5-17-099390-7"),
        new Book("Мастер и Маргарита", "Михаил Булгаков", 1967, "Роман", "978-5-04-000102-3")
    };

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
