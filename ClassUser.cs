using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{

    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string Telefon { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateReg { get; }
        public string Status { get; set; }
        public List<BookLoan> BookLoans { get; }


        public User(string name, string surname, string adress, string telefon, string login, string password)
        {
            Name = name;
            Surname = surname;
            Adress = adress;
            Telefon = telefon;
            Login = login;
            Password = password;
            DateReg = DateTime.Now;
            Status = "user";
            BookLoans = new List<BookLoan>();
        }

        public override string ToString()
        {
            return $"{Name} : {Surname} : {Adress} : {Telefon} ";
        }
    }
    public class BookLoan
    {
        public Book Book { get; set; }
        public DateTime LoanDate { get; }
        public DateTime DueDate { get; }

        public BookLoan(Book book)
        {
            Book = book;
            LoanDate = DateTime.Now;
            DueDate = LoanDate.AddDays(14); // срок возврата через 14 дней
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

}
