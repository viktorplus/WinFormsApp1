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
        public string Adress { get; set; }
        public string Telefon { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateReg { get; }
        public string Type { get; set; }

        public User(string name, string surname, string adress, string telefon, string login, string password)
        {
            Name = name;
            Surname = surname;
            Adress = adress;
            Telefon = telefon;
            Login = login;
            Password = password;
            DateReg = DateTime.Now;
            Type = "user";
        }

        public override string ToString()
        {
            return $"{Name} : {Surname} : {Adress} : {Telefon} ";
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
        public static bool CheckLogin(string username, string password)
        {
            // Ищем пользователя в списке
            User matchingUser = users.FirstOrDefault(user => user.Login == username && user.Password == password);

            return matchingUser != null; // Возвращает true, если пользователь с таким логином и паролем найден
        }
    }




}
