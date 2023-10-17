using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Получите введенный логин и пароль
            string enteredUsername = txtLogin.Text;
            string enteredPassword = txtPassword.Text;

            // Проверьте логин и пароль
            bool isValidLogin = Users.CheckLogin(enteredUsername, enteredPassword);

            if (isValidLogin)
            {
                // Логин и пароль верны, перейдите к UserForm
                User user = new User();
                user.Show();
                this.Hide(); // Скройте текущую форму входа, если необходимо
            }
            else
            {
                // Логин или пароль неверны, выведите сообщение об ошибке
                MessageBox.Show("Неверный логин или пароль. Попробуйте еще раз.");
            }
        }


        private void button_registration_Click(object sender, EventArgs e)
        {
            RegistationForm Registration = new RegistationForm(this);
            this.Visible = false;
            Registration.Show();
        }
    }
}