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
            // �������� ��������� ����� � ������
            string enteredUsername = txtLogin.Text;
            string enteredPassword = txtPassword.Text;

            // ��������� ����� � ������
            bool isValidLogin = Users.CheckLogin(enteredUsername, enteredPassword);

            if (isValidLogin)
            {
                // ����� � ������ �����, ��������� � UserForm
                User user = new User();
                user.Show();
                this.Hide(); // ������� ������� ����� �����, ���� ����������
            }
            else
            {
                // ����� ��� ������ �������, �������� ��������� �� ������
                MessageBox.Show("�������� ����� ��� ������. ���������� ��� ���.");
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