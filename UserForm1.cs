using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.Users;



namespace WinFormsApp1
{
    public partial class UserForm1 : Form
    {
        private User authenticatedUser;

        public UserForm1(User user)
        {
            InitializeComponent();
            authenticatedUser = user;
        }

        private void UserForm1_Load(object sender, EventArgs e)
        {
            // список книг, которые пользователь уже читае"
            UpdateReadingBooksListBox();
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            // Получить параметры поиска 
            string searchCriteria = txtSearchCriteria.Text;

            // Выполнить поиск книг в библиотеке
            List<Book> searchResults = Library.SearchBooksByTitle(searchCriteria);


            // Отобразить результаты поиска в ListBox "Результаты поиска"
            lstSearchResults.Items.Clear();
            lstSearchResults.Items.AddRange(searchResults.ToArray());
        }

        private void btnTakeBook_Click(object sender, EventArgs e)
        {
            if (lstSearchResults.SelectedIndex >= 0)
            {
                Book selectedBook = (Book)lstSearchResults.SelectedItem;

                // Взять книгу и добавить ее в список "Книги, взятые в библиотеке" пользователя
                authenticatedUser.ReadBook(selectedBook);

                // Удалить книгу из библиотеки
                Library.RemoveBook(selectedBook);

                // Обновить ListBox
                UpdateReadingBooksListBox();
            }
        }


        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (lstReadingBooks.SelectedIndex >= 0)
            {
                Book selectedBook = (Book)lstReadingBooks.SelectedItem;

                // Вернуть книгу и добавить ее обратно в библиотеку
                authenticatedUser.ReturnBook(selectedBook);

                // Обновить ListBox
                UpdateReadingBooksListBox();
            }
        }

        private void UpdateReadingBooksListBox()
        {
            // Очистить ListBox "Книги, взятые в библиотеке" и загрузить книги из списка пользователя
            lstReadingBooks.Items.Clear();
            lstReadingBooks.Items.AddRange(authenticatedUser.BooksReading.ToArray());
        }

    }

}
