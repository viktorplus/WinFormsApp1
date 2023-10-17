using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text;
            string password = txtPassword.Text;

            // Проверка логина и пароля
            User authenticatedUser = Users.CheckLogin(username, password);

            if (authenticatedUser != null)
            {
                // Пользователь успешно аутентифицирован
                string userStatus = authenticatedUser.Status;

                // Определение, куда перенаправить пользователя
                if (userStatus == "user")
                {
                    // Перенаправить на форму пользователя
                    UserForm1 userForm = new UserForm1(username);
                    userForm.Show();
                }
                else if (userStatus == "bibliotekar")
                {
                    // Перенаправить на форму библиотекаря
                    BibliotekarForm bibliotekarForm = new BibliotekarForm(username);
                    bibliotekarForm.Show();
                }
                else if (userStatus == "admin")
                {
                    // Перенаправить на форму админа
                    AdminForm adminForm = new AdminForm(username);
                    adminForm.Show();
                }
            }
            else
            {
                // Ошибка аутентификации
                MessageBox.Show("Неверный логин или пароль. Попробуйте еще раз.");
            }
        }


        private void Loginbutton_registration_Click(object sender, EventArgs e)
        {
            RegistationForm Registration = new RegistationForm(this);
            this.Visible = false;
            Registration.Show();
        }

    }
}