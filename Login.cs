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
            // �������� ��������� ����� � ������
            string enteredUsername = txtLogin.Text;
            string enteredPassword = txtPassword.Text;

            // ��������� ����� � ������
            bool isValidLogin = Users.CheckLogin(enteredUsername, enteredPassword);

            if (isValidLogin)
            {
                MessageBox.Show("Ok");
                // ����� � ������ �����, ��������� � UserForm
                UserForm1 user = new UserForm1();
                user.Show();
                Hide(); // ������� ������� ����� �����, ���� ����������
            }
            else
            {
                // ����� ��� ������ �������, �������� ��������� �� ������
                MessageBox.Show("�������� ����� ��� ������. ���������� ��� ���.");
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