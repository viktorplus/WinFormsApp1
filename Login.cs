using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            // Получите введенный логин и пароль
            string enteredUsername = txtLogin.Text;
            string enteredPassword = txtPassword.Text;

            // Проверьте логин и пароль
            bool isValidLogin = Users.CheckLogin(enteredUsername, enteredPassword);

            if (isValidLogin)
            {
                MessageBox.Show("Ok");
                // Логин и пароль верны, перейдите к UserForm
                UserForm1 user = new UserForm1();
                user.Show();
                Hide(); // Скройте текущую форму входа, если необходимо
            }
            else
            {
                // Логин или пароль неверны, выведите сообщение об ошибке
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